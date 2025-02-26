import os
import tkinter as tk
from tkinter import filedialog
from pil import Image, imagetk 

class ImageBrowserApp:
    def_init_(self, root):
    self.root = root
    self.root.title("Navegador de Imagens")

    self.image_paths = []
    self.current_image_index = 0

    self.image_label = tk.Label(root)
    self.image_label.pack(padx = 10, pady = 10)
    
    browse_button = tk.button(root, text = "Selecionar Diretório",
                    command = self.browse_directory)
    browse_button.pack(padx = 10, pady = 5)

    self.prev_button = tk.button(root, text="Anterior", state=tk.DISABLED,
                       command = self.show_previous_image)
    
    self.prev_button.pack(side = tk.LEFT, padx = 10, pady = 5)

    self.next_button = tk.button(root, text = "Próxima", state = tk.DISABLED,
                        command = self.show_next_image)
    
    self.next_button.pack(side = tk.RIGHT, padx = 10, pady = 5)

def browse_directory(self):
  directory_path = filedialog.askdirectory()
  if directory_path:
     self.image_paths = [
        os.path.join(directory_path, file)
        for file in os.listdir(directory_path)
        if file.lower().endswith(('.png', '.jpg', '.jpeg', '.gif'))
    ]
    if self.image_paths:
       self.current_image_index = 0
       self.show_image(self.current_image_index)
       self.prev_button.config(state = tk.NORMAL)
       self.next_button.config(state = tk.NORMAL)
    else:
       self.image_label.config(text = "Nenhuma imagem encontrada")

def show_image(self, index):
   image_path = self.image_paths[index]
   try:
       image = Image.open(image_path)   
       image = image.resize((300, 300)) 
       photo = ImageTk.PhotoImage(image)
       self.image_label.config(image = photo)

       self.image_label.image = photo
    execpt Exception as e:
        self.image_label.config(text=f"Erro ao abrir imagem: {str(e)}")

def show_previous_image(self):
   if self.current_image_index > 0:
      self.current_image_index -= 1
      self.show_image(self.current_image_index)

def show_next_image(self):    
   if self.current_image_index < len(self.image_paths) - 1:
      self.current_image_index += 1
      self.show_image(self.current_image_index)

   if_name_ =="_main_":
     root = tk.tk()
     app = ImageBrowserApp(root)
     root.mainloop()