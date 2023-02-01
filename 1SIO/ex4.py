#Algorithme: A1
	nb = int(input("veuillez saisir un nombre"))
	if (nb % 6) == 0 :
	print("Le nombre est un multiple de 6")
	if (nb % 3) == 0 :
	print("Le nombre est un multiple de 3 mais pas de 6")
	if (nb % 2) == 0 :
	print("Le nombre est un multiple de 2 mais pas de 6")
	else :
	print("Le nombre n'est ni multiple de 2, ni de 3")