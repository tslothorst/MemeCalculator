# MemeCalculator
## Who needs efficiency?
What is this repo all about? On the r/ProgrammingHumor subreddit there is a meme about ~~poorly~~ brilliantly made calculator apps. This is my contribution to the meme. The basic outline of the meme is to create a calculator which does it's job in the strangest way possible usually by looping through a large amount of ' if' statements to find the answer to the mathematical operations requested. 

## Whats in the bag? A calculator or something?
Sorta. 

I took a different approach since C# refuses to compile when you hit a certain threshold of 'if' statments. This calculator currently supports addition, substraction, mutiplication and division for numbers ranging between -1000 and 1000. This number is set in the code so you can adjust it to your needs. The program does it's job my creating a dictionary for each operations and converts the operation (e.g. 1 + 1) to a string, it adds this to the dictionary with the result ( 2 ) as a key value pair. The entered operation on the console is converted into a string which will be looked up in the dictionaries to find the answer to the operation. 

Starting the program is a bit more work. At start-up the dictionaries are populated. This will stress test your CPU. Memory is worth mentioning too, with the range of -1000 to 1000 it needs about 1,5G of memory to run. 

## Should I even be running this?
This project is a joke. It's not really a paragon of proper programming and is for entertainment only.

Running this program will put some load on your machine, you've been warned. 
