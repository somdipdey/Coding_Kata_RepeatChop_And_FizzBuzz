# This mini project tackles two challenges as follows

## 1) ====== Remove Extra Chars ======
	Return a string where the number of consecutive characters of the same value is limited to the parameter supplied
	Example: "aaabbcccccdddd".RemoveConsecuitiveChars(2) should return "aabbccdd"

## 2) ====== Fizz Buzz ======
	Should return each number between zero and its parameter but replaces multiples of 3 with 'Fizz' and multiples of 5 with 'Buzz'
    Where the number of 'z' characters each word is the same as the other factor of the input number
    For multiples of both 3 and 5 replace the number with both of the corresponding 'Fizz'-'Buzz' words. eg 15=\"Fizzzzz-Buzzz\

# Solutions

## Challenge 'Remove Extra Chars'
	In the StringExtension class, RemoveConsecuitiveChars(int) method accepts the number of allowed consecutive characters as int.
	The characters in the passed string are put into a HasSet so that the distinct characters in the string can be retrieved. And then use the string
	buidling method to build the final string based on the allowed consecutive characters.The implementation has a time complexity of O(N).

## Challenge 'Fizz Buzz'
	In the FizzBuzzCalculator class the method FizzBuzz(int) is broken into smaller task to achieve completion of this method. Inside the FizzBuzz method an iterator ietrates till the int provided
	as argument to the method from 0. For each number in the ietration, the factorial of that number divisible by 3 or and 5 are retrived in the form of Tuples.
	This implemntation also has time complexity of O(N). The return value of FizzBuzz(int) is a list of string obejcts and the gcAllowVeryLargeObjects is set to true to enable the CLR to allow large objects
	greater than 2GB during the runtime. This method is also executed for FizzBuzz(100000) and the program ran to completion. 
	
# Result Screenshot

![Solution Result Fizz Buzz](https://user-images.githubusercontent.com/8515608/33633571-43848d1a-da09-11e7-8914-d4fc19773d93.png "Remove repetetive characters")
	
![Solution Result Fizz Buzz](https://user-images.githubusercontent.com/8515608/33633569-434677f0-da09-11e7-81aa-df4bfc00ee88.png "Fizz Buzz output on console")

#### Fizz Buzz solution's memory footprint for Parameter = 100,000 i.e. FizzBuzz(100000)

![Solution Result Fizz Buzz](https://user-images.githubusercontent.com/8515608/33633570-436ac4ca-da09-11e7-922d-1290c942d8fb.png "Fizz Buzz application footprint on memory for Parameter = 100,000")

