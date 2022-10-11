import threading
import tkinter as tk
from tkinter import ttk
from pytube import YouTube       # pip install --upgrade pytube  kütüphaneyi terminalden güncellemeyi unutmayın 
from PIL import Image, ImageTk  # Pillow kütüphanesinden gerekli modülleri içe aktarıyor bu yüzden "pip install pillow" terminal komutu ile pillow kütüphanesini indirebilirsiniz.
import sys
import time

root = tk.Tk()
root.title("İndiriliyor")
'''
progress_var = tk.IntVar()
progress_bar = ttk.Progressbar(root, variable=progress_var, maximum=100)
progress_bar.pack(fill="x", padx=10, pady=5)
'''
# fotoğrafı eklemek için
image = Image.open("C:\\Users\\Fatih\\Desktop\\İndirme\\my.jpg") # indirme barının üstündeki fotoğraf için path belirttim
image = image.resize((200, 200))
photo = ImageTk.PhotoImage(image)
logo_label = ttk.Label(root, image=photo)
logo_label.pack(pady=10)

progress = ttk.Progressbar(root, orient="horizontal", length=500, mode="determinate", style="Green.Horizontal.TProgressbar")
progress.pack(pady=10)

style = ttk.Style()
style.theme_use("default")
style.configure("Green.Horizontal.TProgressbar", background="green")

video_url = sys.argv[1]
kalite = sys.argv[2]

def update_progress(stream, chunk, bytes_remaining):
    file_size = stream.filesize
    bytes_downloaded = file_size - bytes_remaining
    progress["value"] = (bytes_downloaded / file_size) * 100
    root.update_idletasks()




def download_video1():
    # YouTube nesnesi oluştur
    video = YouTube(video_url, on_progress_callback=update_progress)
    start_time = time.time() # İndirme işlemi başlamadan önce zamanı kaydet
    # Videoyu en yüksek kalitede indir
    stream = video.streams.filter(progressive=True).order_by('resolution').first()
    stream.download("C:\\Users\\Fatih\\Desktop\\")
    # İndirme tamamlandığında mesaj göster
    end_time = time.time() # İndirme işlemi bittikten sonra zamanı kaydeder
    print(f"Video {end_time - start_time} saniyede indirildi.") # Terminale İndirme süresini yaz 
    tk.Label(root, text=f"Video başarıyla indirildi.\n{end_time - start_time} saniyede indirildi.", fg ="red").pack(pady=10) # Video inince Barın altına yazar


def download_video2():
    # YouTube nesnesi oluştur
    video = YouTube(video_url, on_progress_callback=update_progress)
    start_time = time.time() # İndirme işlemi başlamadan önce zamanı kaydeder
    # Videoyu en yüksek kalitede indirir
    stream = video.streams.get_highest_resolution()
    stream.download("C:\\Users\\Fatih\\Desktop\\")
    # İndirme tamamlandığında mesaj gösterir
    end_time = time.time() # İndirme işlemi bittikten sonra zamanı kaydeder
    print(f"Video {end_time - start_time} saniyede indirildi.") # Terminale İndirme süresini yaz 
    tk.Label(root, text=f"Video başarıyla indirildi.\n{end_time - start_time} saniyede indirildi.", fg ="red").pack(pady=10) # Video inince Barın altına yazar

def download_video3():
    # YouTube nesnesi oluştur
    video = YouTube(video_url, on_progress_callback=update_progress)
    start_time = time.time() # İndirme işlemi başlamadan önce zamanı kaydet
    # Videoyu en yüksek kalitede indir
    stream = video.streams.filter(res="1080p").first()
    stream.download("C:\\Users\\Fatih\\Desktop\\")
    # İndirme tamamlandığında mesaj göster
    end_time = time.time() # İndirme işlemi bittikten sonra zamanı kaydet
    print(f"Video {end_time - start_time} saniyede indirildi.") # Terminale İndirme süresini yaz 
    tk.Label(root, text=f"Video başarıyla indirildi.\n{end_time - start_time} saniyede indirildi.", fg ="red").pack(pady=10) # Video inince Barın altına yazar

def download_video4():
    # YouTube nesnesi oluştur
    video = YouTube(video_url, on_progress_callback=update_progress)
    start_time = time.time() # İndirme işlemi başlamadan önce zamanı kaydet
    # Videoyu en yüksek kalitede indir
    stream = video.streams.filter(res="2160p").first()
    stream.download("C:\\Users\\Fatih\\Desktop\\")
    # İndirme tamamlandığında mesaj göster
    end_time = time.time() # İndirme işlemi bittikten sonra zamanı kaydet
    print(f"Video {end_time - start_time} saniyede indirildi.") # Terminale İndirme süresini yaz 
    tk.Label(root, text=f"Video başarıyla indirildi.\n{end_time - start_time} saniyede indirildi.", fg ="red").pack(pady=10) # Video inince Barın altına yazar



def Running1():
    # İndirme işlemini farklı bir thread'de çalıştır
    threading.Thread(target=download_video1).start()
def Running2():
    # İndirme işlemini farklı bir thread'de çalıştır
    threading.Thread(target=download_video2).start()
def Running3():
    # İndirme işlemini farklı bir thread'de çalıştır
    threading.Thread(target=download_video3).start()
def Running4():
    # İndirme işlemini farklı bir thread'de çalıştır
    threading.Thread(target=download_video4).start()    


if kalite == "1":
    button = tk.Button(root, text="Videoyu İndir", command=Running1)
    button.pack(pady=10)
    root.mainloop()
elif kalite == "2":
    button = tk.Button(root, text="Videoyu İndir", command=Running2)
    button.pack(pady=10)
    root.mainloop()
elif kalite == "3":
    button = tk.Button(root, text="Videoyu İndir", command=Running3)
    button.pack(pady=10)
    root.mainloop()
elif kalite == "4":
    button = tk.Button(root, text="Videoyu İndir", command=Running4)
    button.pack(pady=10)
    root.mainloop()
