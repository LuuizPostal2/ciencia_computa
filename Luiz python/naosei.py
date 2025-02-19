import random
def jogo_adivinhacao():
    numero_aleatorio = random.randint(1, 10)
    max_tentativas = 8

    print("Bem-Vindo ao Jogo de Adivinhação!")
    print("Tente adivinhar o número entre 1 e 10.")

    for tentativa in range(max_tentativas) :
        palpite = int(input("Digite sua tentativa:"))

     if palpite < numero_aleatorio:
          print("Muito baixo. Tente")