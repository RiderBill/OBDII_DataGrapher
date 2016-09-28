2016-09-28. Bill Brinson
I bought an OBD II scan tool to diagnose a few mystery problems on my wife's
2000 Mecury Sable a few years ago. The built in plotting function was almost
useless. There is a barely functional program that will download the
collected data to a text file on my laptop, but the format of that data is
terrible--impossilbe to drag into Excel to plot it, for example.

Since I was trying to teach myself C# at the time, I decided to write a code
to make sense of the OBD II data. A lot more could be done, but the code turned
out pretty well, IMHO. I used it again with some success on my daughter's
2006 Kia Spectra 5, which was FUBAR at the time--bad Catalytic converter,
suspect O2 sensors (one was bad), a bad vapor system vent valve... The
frozen ac compressor, leaking radiator, etc. were beyond the scope of an
OBD II scan tool, of course. Half the advice on the internet was
"It's a Kia! What did you expect?" [groan]

Back to the code. IMHO. By the time I used it to diagnose the Kia, I'd slept
enough times that I'd forgotten the details of the code. The WinForm layout
was intuitive enough that I didn't need to look at the code to use it. The
code allows you to import a Scan tool text file, chose channels, view the
data as a useable table, or plot as many channels as makes sense, either
individually, or on a single chart. Not an example of stellar programming,
but it works. It even has a decent Help/About function.

You can test the code using one of the data files in the TestRuns directory.
Some of the data files are better than others; try several of them.