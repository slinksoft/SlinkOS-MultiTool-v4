# SlinkOS-MultiTool-v4
A personal .NET project that showcases various tools in one program such as screen capture, bit converter, equation calculator, clipboard history, and more

SOURCE WILL BE RELEASED IN THE COMING WEEKS.

Original description from [Slink Soft](https://realslinksoft.wixsite.com/slink-soft-portfolio/project-releases):

SlinkOS is finally here! This is essentially MultiTool v4, but it is much bigger than just MultiTool. New tools have been added, previous tools have been improved, and you have the option to install SlinkOS to startup! SlinkOS's main goal is to add features to your Windows Operating System that should be included. See the video above for further details on each feature.

SlinkOS is now out of BETA as of version 4.6-68.

What's New In MultiTool:
- Censorbar
- Screenshot Tool
- Clipboard History
- Powerstate Options
- Ability to install SlinkOS on startup
- Linux-feel Terminal
- Improvements to previous tools
<hr>

Essentially, I started the SlinkOS (MultiTool v4) project back when Windows 8 was transitioning to Windows 10. There were some features that were obviously missing in Windows back then (or were confusing to access) such as clipboard history, screen capture snip tool, post notes, power options (hibernate, sleep, lock, etc.), and more. Other tools I implemented revolve around the previous versions of MultiTool during my rookie days of software development (high school and beginning of college), such as timers and stopwatches, simple web browsers, equation calculators, etc., while others were implemented to assist some of my foundational studies of computer science during my undergrad course work, including bit converters, and equation calculators.

One feature I wanted to implement was a custom Linux-like terminal, with commands that can control the functionality of MultiTool v4, and manipulate data on your computer, including background process handling and file IO functionality (manipulating files and directories).

Now, in 2021, after working on SlinkOS for over 4 years, I've realized it is time to put an end to this project, as modern Windows 10 includes majority of the features that I implemented. I've graduated college with my B.S in Computer Science, I have a full-time software development job at a compnay I am proud to be a part of, and family/life to focus on. On top of all of this, I am taking on projects at my company in which I am getting paid for in order to develop towards these projects, so there's barely any time for me to continue working on SlinkOS.

I meant to release the source sooner, but was afraid it was not ready in its current state due to a lack of comments and some code that I haven't had a chance to clean up and optimize (spoiler alert, never got around to finishing this completely!).

So here it is: the SlinkOS source code I've promised for 2 years after SlinkOS went out of beta. The latest release is avaiable for download on the releases page. If you wish to modify implementations and/or rebuild, simply open the project in Visual Studio. The project is running on .NET Framework, with the use of CefSharp and NCalc.

Check out this [video](https://www.youtube.com/watch?v=YdBM1s9Scas&feature=emb_title) to get a feel for SlinkOS (THIS VIDEO IS A WAY OLDER VERSION OF SLINKOS, ONE OF THE FIRST OUT OF BETA. The latest release has many more features and optimized functionality).

Thank you all for the support! I now present you with the final version of SlinkOS - MultiTool v4: 4.90-20!

<h3>PLEASE NOTE: The source code will not contain the binaries for CefSharp, as they are too big to upload onto Github. You must go into the Nuget Package Manager for the project and re-add them. If you do not do this, the code will not compile.</h3>
