import tkinter as tk
from tkinter import filedialog
from tkinter import ttk
import hashlib
import threading
import os

def select_file():
    select_button.config(state=tk.DISABLED)  # Dosya seç butonunu devre dışı bırak
    file_path = filedialog.askopenfilename(title="Dosya Seç")
    if file_path:
        selected_path.set("Seçili Dosya Yolu: " + file_path)
        hash_value.set("Hesaplanıyor...")
        # Hesaplama işlemini başka bir thread içinde yap
        thread = threading.Thread(target=calculate_sha256, args=(file_path,))
        thread.start()

def calculate_sha256(file_path):
    try:
        sha256_hash = hashlib.sha256()
        file_size = os.path.getsize(file_path)
        with open(file_path, "rb") as file:
            read_size = 0
            while True:
                data = file.read(8196)  # 8 KB'lık bloklarla işlem yapabilirsiniz.
                if not data:
                    break
                sha256_hash.update(data)
                read_size += len(data)
                # Yüzdelik çubuğu güncelle
                progress = int((read_size / file_size) * 100)
                progress_var.set(progress)
        hash_result = sha256_hash.hexdigest()
        hash_value.set("SHA-256 Hash Değeri: " + hash_result)
    except Exception as e:
        hash_value.set("Hata: Dosya okuma sırasında bir sorun oluştu.")
    finally:
        select_button.config(state=tk.NORMAL)  # Dosya seç butonunu tekrar etkinleştir

# Ana pencereyi oluştur
root = tk.Tk()
root.title("SHA-256 Hash Hesaplayıcı")
root.geometry("640x480")  # Pencere boyutunu ayarlayın

# Dosya seçme düğmesini oluştur
select_button = tk.Button(root, text="Dosya Seç", command=select_file)
select_button.pack(pady=10)

# Seçilen dosyanın yolu için bir metin etiketi
selected_path = tk.StringVar()
path_label = tk.Label(root, textvariable=selected_path)
path_label.pack()

# Yüzdelik çubuk
progress_var = tk.IntVar()
progress_bar = ttk.Progressbar(root, variable=progress_var, maximum=100)
progress_bar.pack(fill="x", padx=10, pady=5)

# SHA-256 hash değeri için bir etiket ve değişken
hash_label = tk.Label(root, text="SHA-256 Hash Değeri:")
hash_label.pack()
hash_value = tk.StringVar()
hash_value_label = tk.Label(root, textvariable=hash_value)
hash_value_label.pack()

root.mainloop()