# Example of a basic .Net 7 Web App that downloads a test file and then exits abruptly

This isn't a total newbie question. I've been developing in .Net for many many years.

But I was trying to get a better way of downloading files to the user from an application I was developing without using Javascript and just use what .Net 7 and Razor pages provided.
Yes it works very well when you provide a simple form and a submit button inside it. The browser asks what do you want to call this file and where would you like it.

However the real problem is that as soon as you have done that, the app exits. This means you can't click on the button again because the server has stopped.
There a few examples out there on how to use "PhysicalFile" to retrieve a file and download it through the browser. But none of them mention this problem.

Does anybody have ideas on why this is happening?

**Problem solved!**

So I have managed to answer my own question. The problem was the browser. I recently switched to Brave. When I specify another browser (Chrome, Duck Duck Go, Firefox) almost anything except Brave. It works just as it should. So the problem was the way that Brave and Visual Studio 2022 talk to each other. They are not good together. So I'm going to stick to developing on Chrome. Phew!
