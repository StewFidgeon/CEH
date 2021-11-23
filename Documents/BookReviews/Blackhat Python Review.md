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

Chapter 2 covers various networking basics like TCP & UDP clients & servers and very quickly moves on to replacing netcat in case a sysadmin has removed it. Next up you start building your own simple proxy for traffic forwarding and analysis. After that you build your own SSH client using the Paramiko library.

Chapter 3 covers raw sockets and sniffing, which begins with building your own UDP host discovery tool and setting up packed capture in promiscuous mode. There's a very brief overview of the structure of an ipv4 packet header before moving on to decode the packet contents. This chapter introduces andmakes use of the netaddr library.

Chapter 4 is about owning the network with the Scapy packet manipulation library. The chapter begins by examining building a simple packet sniffer to capture SMTP, POP3, and IMPA credentials. The chapter progresses to cover ARP cache poisoning also using Scapy for this MITM attack. The chapter closes with logging the packet output to a PCAP file for analysis, and performing on the fly facial detection in any images within the captured packets.

Chapter 5 discusses web hacking and begins with introducing the socket library urllib2. The chapter begins with executing a simple GET request and printing the response, and quickly enhances that to use a customer User-Agent HTTP Header. You then move on to building a scanner to map left over installations files for WordPress, Drupal, Joomla and other blogging platforms - these installations are often not up to date with their patching. The samepiece of code also makes use of Python threading for the first time in the book. The chapter then takes a look at brute forcing directory paths to achieve the same thing but with less knowledge of what is expected to be found, and suggests the use of DirBuster word lists and OWASPs list of vulnerable web apps against which to test your script. The chapter concludes by takig a look at HTML form authentication and how to brute force it where its been implemented without account lockouts or strong CAPTCHA's. 

Chapter 6 extends the burp proxy.

Chapter 7 covers Github command & control.

Chapter 8 is about common trojaning techniques on Windows.

Chapter 9 is about manipulating Internet Explorer.

Chapter 10 is Windows privilege escalation.

Chapter 11 is about automating offensive forensics.

## What was good about the book?
The code samples explain in sufficient depth what is happening with data at each stage such that reproducing similar tools in another language is easier because the understanding of wat is happening with packets etc remains the same.

## What could be improved, clarified, or covered in more depth?
The code samples provided in my version of the book are all in Python 2 which is EOL, and converting them to Python 3 has been challenging due to my lack of Python experience.  It's a minor niggle with the book as I'm sure someone who does a lot of work with Python would be able to manage the conversion quickly and easily, and there are other peoples conversions available for reference in github.

## What did I learn from reading it?
I learned that building your own tools is easily in reach of most competent software developers and that while language choice may simplify doing so, its not essential to restrict yourself to only one language.   If you find yourself unable to deploy your usual offensive tooling onto a target box or you want to stay off the radar, then the ability to craft your own tools in whatever language runtime options are available will be useful.

I also learned a lot more about applied networking than I had when doing the CEH course as that was more focused on the use of existing tools and theoretical knowledge than it was applying that knowledge to the production of your own tools.  If the EC Council were looking to bring the course more to the applied level rather than theoretical, that may be a useful consideration for a future module.

## Would I recommend the book to other people at my stage of the InfoSec journey?
Yes. One of the important definitions between an InfoSec professional and a script kiddy is being able to write your own tools because you understand what the tools are doing, and with sufficient experience, being able to find your own exploits.
