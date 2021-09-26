### Blackhat Python

## Book Specification
ISBN number: 978-1-59327-590-7
Number of pages: 170
Author: Justin Seitz
Publisher: no starch press

## What's the book about?

The book is essentially a how to manual for writing your own security analysis tools in python and covers a brief outline of how each of them work, with code samples provided.

## What specifically does the book cover?
Chapter 1 is an introductory guide to help set up the required language tools and runtimes.

Chapter 2 covers various networking basics like TCP & UDP clients & servers and very quickly moves on to replacing netcat in case a sysadmin has removed it. Next up you start building your own simple proxy for traffic forwarding and analysis. After that you build your own SSH client using Paramiko.

Chapter 3 covers raw sockets and sniffing.  

## What was good about the book?
The code samples explain in sufficient depth what is happening with data at each stage such that reproducing similar tools in another language is easier because the understanding of wat is happening with packets etc remains the same.

## What could be improved, clarified, or covered in more depth?
The code samples provided in my version of the book are all in Python 2 which is EOL, and converting them to Python 3 has been challenging due to my lack of Python experience.  It's a minor niggle with the book as I'm sure someone who does a lot of work with Python would be able to manage the conversion quickly and easily.

## What did I learn from reading it?
I learned that building your own tools is easily in reach of most competent software developers and that while language choice may simplify doing so, its not essential to restrict yourself to only one language.   

I also learned a lot more about applied networking than I had when doing the CEH course as that was more focused on the use of existing tools and theoretical knowledge than it was applying that knowledge to the production of your own tools.

## Would I recommend the book to other people at my stage of the InfoSec journey?
Yes. One of the important definitions between an InfoSec professional and a script kiddy is being able to write your own tools because you understand what the tools are doing, and with sufficient experience, being able to find your own exploits.
