print("---------------------------------------------")
print("Complemento5: CALCULAR TIEMPO DE ENCUENTRO.")
print("---------------------------------------------")

print("Ingrese las velocidades de ambos vehiculos:")
v1 = float(input("V1:"))
v2 = float(input("V2:"))
print("Ingrese la distancia que los serapa:")
d = float(input("Distancia:"))

print("\nSALIDA:")
print("---------------------------------------------")

if v1 > 0 and v2 > 0: 
    t = d/(v1+v2)
    print(t,"Segundos")
else: 
    print("ERROR")
