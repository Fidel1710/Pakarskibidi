import sys

# ==========================================
# 1. CONSTANTS & KNOWLEDGE BASE
# ==========================================

# User Confidence Weights mapping
USER_CONFIDENCE_LEVELS = {
    1: ("Sangat Yakin (Very Confident)", 1.0),
    2: ("Yakin (Confident)", 0.70),
    3: ("Cukup Yakin (Quite Confident)", 0.5),
    4: ("Agak Yakin (Somewhat Confident)", 0.25),
    5: ("Kurang Yakin (Less Confident)", 0.1)
}

# Course Dictionary (Code -> Name)
COURSES = {
    "MK01": "Teori Automata",
    "MK02": "AR and VR",
    "MK03": "Mobile Programming",
    "MK04": "Sistem Pendukung Keputusan",
    "MK05": "Database",
    "MK06": "Web Programming",
    "MK07": "Data Mining",
    "MK08": "Data Science",
    "MK09": "Analisis Data",
    "MK10": "Sistem Pakar",
    "MK11": "Manajemen Software",
    "MK12": "Big Data",
    "MK13": "Sistem Otomasi",
    "MK14": "IoT",
    "MK15": "Artificial Intelligence",
    "MK16": "Pengolahan Citra",
    "MK17": "Robotik",
    "MK18": "Jaringan Komputer"
}

# Projects Knowledge Base
# Format: "Project Code": {"title": "Title Name", "rules": {"Course Code": Expert_CF, ...}}
PROJECTS = {
    "J01": {
        "title": "Rancang Bangun Game 2D Shooter Platformer Menggunakan Metode Finite State Machine",
        "rules": {"MK01": 0.9, "MK02": 0.8, "MK03": 0.4}
    },
    "J02": {
        "title": "Rancang Bangun Game 2D Shooter Platformer Menggunakan Metode Finite State Machine",
        "rules": {"MK04": 0.9, "MK05": 0.8, "MK06": 0.5}
    },
    "J03": {
        "title": "Prediksi Permintaan Mata Kuliah Pada Semester Padat Dengan Menggunakan Teknik Association Rule Dengan Algoritma Apriori Pada Fakultas Teknologi Informasi",
        "rules": {"MK07": 0.8, "MK08": 0.6, "MK09": 0.9}
    },
    "J04": {
        "title": "Analisis Perbandingan Framework CodeIgniter Dan Framework Laravel (Studi Kasus Inventaris HMJ TI STMIK AKAKOM Yogyakarta)",
        "rules": {"MK06": 0.8, "MK09": 0.3, "MK11": 0.5}
    },
    "J05": {
        "title": "Sistem Pakar Diagnosa Penyakit Pencernaan Pada Manusia Menggunakan Metode Certainty Factor Berbasis Web",
        "rules": {"MK10": 1.0, "MK06": 0.8, "MK09": 0.6}
    },
    "J06": {
        "title": "Klasifikasi Topik Berita Dan Analisis Sentimen Pada Tweets Divisi Humas Polri Dengan Metode Naïve Bayes Classifier",
        "rules": {"MK07": 0.9, "MK09": 0.8, "MK12": 0.5}
    },
    "J07": {
        "title": "Group Decision Support System (GDSS) untuk Pemilihan Konsentrasi Studi Mahasiswa Menggunakan AHP dan TOPSIS",
        "rules": {"MK04": 1.0, "MK07": 0.8, "MK11": 0.2}
    },
    "J08": {
        "title": "Sistem Monitoring Keadaan Ruang Laboratorium Fakultas Komunikasi Dan Informatika Di Universitas Muhammadiyah Surakarta",
        "rules": {"MK13": 1.0, "MK03": 0.8, "MK14": 0.8}
    },
    "J09": {
        "title": "Penerapan Metode Jaringan Syaraf Tiruan Pada Sistem Deteksi Citra Darah Manusia",
        "rules": {"MK15": 0.8, "MK16": 1.0, "MK09": 0.6}
    },
    "J10": {
        "title": "Aplikasi Manajemen Central Rental Mobil Menggunakan Framework CodeIgniter (Study Kasus: Guntur Sakti Rental)",
        "rules": {"MK06": 1.0, "MK11": 0.6, "MK05": 0.4}
    },
    "J11": {
        "title": "Otomatisasi Penyiram Dan Pencahayaan Tanaman Buah Naga Berbasis Arduino Uno Menggunakan Energy Panel Surya",
        "rules": {"MK14": 0.9, "MK13": 0.9, "MK17": 0.4}
    },
    "J12": {
        "title": "Aplikasi Augmented Reality Pada Pemasaran Perumahan Puri Lestari Di Cikarang Berbasis Android",
        "rules": {"MK02": 0.9, "MK03": 0.8, "MK11": 0.6}
    },
    "J13": {
        "title": "Perancangan Dan Penerapan Aplikasi Kasir Dengan Menggunakan Bahasa Pemrograman PHP Dan MySQL Di Warung Kopi 'Gojeg'",
        "rules": {"MK05": 0.8, "MK11": 0.6, "MK06": 1.0}
    },
    "J14": {
        "title": "Implementasi Metode Fuzzy Logic Untuk Sistem Pengukuran Kualitas Udara Di Kota Medan Berbasis Internet Of Things (IoT)",
        "rules": {"MK14": 1.0, "MK09": 0.4, "MK15": 0.2}
    },
    "J15": {
        "title": "Rancang Bangun Sistem Enkripsi Pengiriman Informasi Menggunakan Algoritma Kriptografi Klasik",
        "rules": {"MK18": 0.8, "MK16": 0.9, "MK09": 0.4}
    }
}

# ==========================================
# 2. CALCULATION ENGINE
# ==========================================

def calculate_single_cf(expert_cf, user_cf):
    """
    Calculate CF[H,E] = CF[H] * CF[E]
    """
    return expert_cf * user_cf

def combine_cfs(cf_list):
    """
    Combine a list of CF values using the formula:
    CF_new = CF_old + CF_next * (1 - CF_old)
    """
    if not cf_list:
        return 0.0, []

    # Sort to ensure deterministic calculation order (optional, as formula is commutative)
    # But keeping it as is or sorting by value might be useful for logging.
    # The prompt example combines 0.81 and 0.56. 
    
    steps = []
    cf_old = cf_list[0]['value']
    steps.append(f"Start with CF1: {cf_old:.4f} ({cf_list[0]['course']})")

    for i in range(1, len(cf_list)):
        cf_next = cf_list[i]['value']
        course_next = cf_list[i]['course']
        
        # Formula: CF_combine = CF1 + CF2 * (1 - CF1)
        cf_new = cf_old + cf_next * (1 - cf_old)
        
        steps.append(f"Combine with CF{i+1}: {cf_old:.4f} + {cf_next:.4f} * (1 - {cf_old:.4f}) = {cf_new:.4f} ({course_next})")
        cf_old = cf_new

    return cf_old, steps

# ==========================================
# 3. MAIN LOGIC
# ==========================================

def get_user_input_interactive():
    """
    Interactive console input for users to select courses and confidence levels.
    """
    print("\n=== INPUT PHASE ===")
    print("Available Courses:")
    sorted_courses = sorted(COURSES.items())
    for code, name in sorted_courses:
        print(f"[{code}] {name}")

    selected_data = {}
    
    print("\nEnter course codes (e.g., MK01) one by one. Type 'DONE' to finish.")
    while True:
        code_input = input("\nEnter Course Code: ").strip().upper()
        if code_input == 'DONE':
            break
        
        if code_input not in COURSES:
            print(f"Error: '{code_input}' is not a valid course code.")
            continue
            
        if code_input in selected_data:
            print(f"You have already entered {code_input}.")
            update = input("Update? (y/n): ").lower()
            if update != 'y':
                continue

        print(f"Selected: {COURSES[code_input]}")
        print("Select Confidence Level:")
        for level, (desc, val) in USER_CONFIDENCE_LEVELS.items():
            print(f"  {level}. {desc} (Weight: {val})")
        
        try:
            choice = int(input("Choice (1-5): "))
            if choice in USER_CONFIDENCE_LEVELS:
                selected_data[code_input] = USER_CONFIDENCE_LEVELS[choice][1]
            else:
                print("Invalid choice. Defaulting to 0.5 (Cukup Yakin)")
                selected_data[code_input] = 0.5
        except ValueError:
             print("Invalid input. Defaulting to 0.5")
             selected_data[code_input] = 0.5
             
    return selected_data

def run_expert_system(user_inputs):
    """
    Core logic to process inputs and generate rankings.
    """
    results = []

    for proj_code, proj_data in PROJECTS.items():
        matching_courses = []
        calculated_cfs = []
        
        # Find intersections
        for course_code, expert_cf in proj_data['rules'].items():
            if course_code in user_inputs:
                user_cf = user_inputs[course_code]
                
                # 1. Calculate CF[H,E]
                cf_he = calculate_single_cf(expert_cf, user_cf)
                
                calculated_cfs.append({
                    'course': course_code,
                    'value': cf_he,
                    'expert': expert_cf,
                    'user': user_cf
                })
                matching_courses.append(course_code)

        if not calculated_cfs:
            continue

        # 2. Combine CFs
        final_cf_val, calculation_steps = combine_cfs(calculated_cfs)
        final_percentage = final_cf_val * 100

        results.append({
            'code': proj_code,
            'title': proj_data['title'],
            'percentage': final_percentage,
            'matches': calculated_cfs,
            'steps': calculation_steps
        })

    # Sort by percentage descending
    results.sort(key=lambda x: x['percentage'], reverse=True)
    return results

def display_results(results):
    """
    Format and print the output.
    """
    print("\n" + "="*60)
    print("RECOMMENDATION RESULTS")
    print("="*60)

    if not results:
        print("No suitable projects found based on your inputs.")
        return

    # Display top recommendation specially
    top = results[0]
    print("\n>>> TOP RECOMMENDATION <<<")
    print(f"[{top['code']}] {top['title']}")
    print(f"Confidence Level: {top['percentage']:.2f}%")
    print("-" * 60)

    # Display detailed list
    print("\nAll Matches (Ranked):")
    for idx, res in enumerate(results, 1):
        print(f"\nRank {idx}: [{res['code']}] - {res['percentage']:.2f}%")
        print(f"Title: {res['title']}")
        
        print("Matching Courses:")
        for match in res['matches']:
            c_name = COURSES[match['course']]
            print(f"  - {match['course']} ({c_name}): Expert CF {match['expert']} * User CF {match['user']} = {match['value']:.4f}")
            
        print("Combined CF Calculation:")
        if len(res['steps']) == 1 and "Start" in res['steps'][0]:
             # Single match case
             print(f"  - Single match only: {res['steps'][0]}")
        else:
            for step in res['steps']:
                print(f"  - {step}")
        print("---")

# ==========================================
# 4. EXECUTION
# ==========================================

def run_test_case():
    """
    Runs the specific test case from the prompt.
    """
    print("Running Automated Test Case...")
    # Test Case:
    # MK07 (Data Mining): User CF = 0.7
    # MK06 (Web Programming): User CF = 0.4
    # MK09 (Analisis Data): User CF = 0.9
    
    test_inputs = {
        "MK07": 0.7,
        "MK06": 0.4,
        "MK09": 0.9
    }
    
    results = run_expert_system(test_inputs)
    display_results(results)

if __name__ == "__main__":
    print("Certainty Factor Expert System - Final Project Recommendation")
    
    if len(sys.argv) > 1 and sys.argv[1] == "--test":
        run_test_case()
    else:
        mode = input("Run automated test case? (y/n): ").strip().lower()
        if mode == 'y':
            run_test_case()
        else:
            user_data = get_user_input_interactive()
            if user_data:
                results = run_expert_system(user_data)
                display_results(results)
            else:
                print("No data entered. Exiting.")
