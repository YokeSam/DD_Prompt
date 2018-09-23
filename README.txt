----------------------------------------------------------------------------
Yoke Sam Chin
9/22/2018
Development Environment:
 This is the console application developed using Microsoft Visual Studio 2015 in  C# as programming language.
----------------------------------------------------------------------------

What is the runtime complexity of your solution?

Since this is the console application, the "spaces" in the command-line arguments used as delimiter for the parameters to be passed in to the application. I parsed the arguments to the array of string so that I can manipulate it. The issue is some special character such as caret is a special character in the console and will not be displayed as part of the string. I believe this need to be converted to ascii code in the application in order for it to be displayed on the console.

What is the space complexity of your solution?

In my application, the space in part of the string (for example, ') ()6' ) is trimmed and it is only display as ')()6'); again, this requires additional codes to handle this.
Overall, the application does show the grouping in the solution and in horizontal tree view.




