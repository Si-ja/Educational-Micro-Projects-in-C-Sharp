# Starting with Enums

This repository is mean to help start working with Enum object types. From my personal experience I have not seen them used often, and when I have, I had zero clue what do they do.

## Concept

The main program tries to check what date and time it is currently. Since months are returned as a number values, using enum object type, a check is performed for how the month can be named. If the name ever changes, naturally this can be easily updated not through a long `switch` statement, but through the `Month.cs` file, that has the `enum` object representing each month in words and int format. If you are also coming from `Python` or `JavaScript`, it might help to think of `enum` object type as a sort of a `JSON` 1-level style object. It's not necessarily correct and even comparing `enum` to HashMaps might be easier, but this is the style of thinking that can help you wrap your head around this concept.

## Running

If you run the code, you should receive an answer similar to the following: `June 13, 2021. Current time: 22:49:46`.

Go through the code and see how this is implemented. The `Program.cs` file only acts as a main entry point to the program. In the __Components__ folder, files `Month.cs` has the `enum` object with all the labeled months and the `FindTime.cs` file has the `FindTime` class, that can find the current time and parses it and makes transformations to how the date is generated originally and how it is generated after we make few implementations of our own using the `enum` object. 