#BMI is وزن تقسیم برقد به توان دو
# راهنمای بیشتر در همین مسیر عکس ها موجود می باشد

Weight = input("Your Weight (KG): ")

Weightint = float(Weight)

Height = input("Your Height (M): ")

Heightint = float(Height)

bmi = Weightint / Heightint ** 2

bmiStr = str(bmi)

print("Answer: ", bmiStr)
if bmi <= 18.5 :
    print("your Weight is Low")
elif bmi <= 25 and bmi >= 18.5:
    print(" Your Weight is Ideal")
elif bmi <= 30 and bmi >= 25:
    print(" Your Weight is Little High")
elif bmi >= 30:
    print(" Your Weight is Certainly Fat")

input()


