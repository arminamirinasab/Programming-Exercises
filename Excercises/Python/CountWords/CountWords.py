# Created by Mahdi Mashayekhi

text = input("Enter your text here: ").strip()
count = 0
space = False

for i in text:
    if i == " ":
        if space == False:
            count += 1
            space = True
    else:
        space = False

if text == "":
    print(f"Count of words: {count}")
else:
    print(f"Count of words: {count+1}")
