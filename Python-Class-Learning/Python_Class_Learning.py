# This is a comment in Python

"""
This is a
multi-line
comment
"""
##var_a = 2
##var_b = 3.5
##var_c = "string"

def sum(a, b):
    return a + b

#print("float - " + str(var_b))
#print("int - " + str(int(var_b)))
#print(bool(0))

#user_input = input("Please enter a phrase: ") #gets input from user and stores inside variable
#print("Original input: " + user_input) #uses concatenation to print two strings together
#user_input = user_input.replace("Hello", "g'day") #sets value of variable to amended variable value
#print("Amended input: " + user_input) #uses concatenation to print two strings together

#while(True):
#    user_input = input("Please enter a value: ")
#    while(user_input.isdigit() == False): #checks if all characters in the string are not digits
#        user_input = input("Please enter a numerical value: ") #re-prompts input if string contains no digits
#    user_input = int(user_input) #cast user input from string to int
#    if(int(user_input) > 0 and user_input <= 5): #and operator ensures both conditions are true
#        print("The input number is between 0 and 5.")
#    elif(int(user_input) > 5 and user_input <= 10):
#        print("The input number is between 5 and 10.")

#while(True):
#    user_input = input("Please enter a value: ")
#    while(user_input.isdigit() == False):
#        user_input = input("Please enter a numerical value: ")
#    user_input = int(user_input)
#    if(user_input == 1 or user_input == 0): #or operator checks if one of two conditions is true
#        print("1 or 0 has been input.")
#    elif(user_input == 2 or user_input == 3):
#        print("2 or 3 has been input.")

##animals = ["fish", "bird", "bear", "dog", "cat", "unicorn", "dragon"]
##
##for x in range(len(animals)): #loop for the amount of elements in animals
##    if (animals[x] == "unicorn" or animals[x] == "dragon"): #compare current animal to dragon and unicorn
##        print(animals[x] + " does not exist.") #is an animal that isn't real
##    else:
##        print(animals[x] + " is a real animal.") #is a real animal
        
##q = False        
##while(q == False):
##    print("Program is running")
##    user_input = input("Would you like to quit?")
##    if (user_input == "Y"):
##        q = True

##animals_a = {"fish", "bird", "bear", "dog", "cat", "unicorn", "dragon"}
##
##for animal in animals_a:
##    print(animal)
##
##animals_b = ("fish", "bird", "bear", "dog", "cat", "unicorn", "dragon")
##for animal in animals_b:
##    print(animal)
##
##for X in range(len(animals_b)):
##    print(str(X) + " " + animals_b[X])

##content = "This is a bunch of content."
##content += "\nThis is some more content."
##
##file = open("test.txt", "w") #opening the file stream in "write" mode
##file.write(content + " This is a bunch of test text.") #writing text to a file
##file.close() #closing the file stream
##
##file = open("test.txt", "r") #opening the file stream in "read" mode
##print(file.read()) #reading the content and printing to console
##file.close() #closing the file stream
##
##file = open("test.txt", "a") #opening the file stream in "append" mode
##file.write("This is some extra stuff that has been added.") #adding more content
##file.close() #closing the file stream

collection = ["a", "b", "c", "d", "e", "f", "g"]

def linear_search(search_term):
    for x in collection: #for every element in "collection" array
        if(x == str(search_term)): #compare element value to search parameter
            return True #return True because term has been found
    return False #if the for loop ends, return False

print(linear_search("c"))
    













































