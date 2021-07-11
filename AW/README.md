# Movie Library Instructions

This solution contains four different projects:
- A Data Access Layer
- A Utility Library
- A Web UI Layer
- A Unit Test Project

This coding challenge is composed of a basic prioritized backlog of product requests / feature bugs. They are sorted by most important to least important. The intent of this challenge is to complete as many items in the backlog as possible in the time allotted.

> The purpose of this challenge is to demonstrate general problem solving and programming within a set of real-world like stories. Time is very much a factor in the real world, so carefully evaluate how much effort is invested on each of the criteria so you can complete as many as possible within the allotted time.

> Note: For each challenge(aside from Request #3 and #4) you will want to implement your code in the existing CodingChallenge projects. 

> Note: For each task, please include an explanation  of what you did to resolve the task. For bugs, also include a brief description of what you found wrong.

## Setup

There should be no setup required aside from downloading the source code, validating all packages are downloaded, and compiling / running the application within IIS Express. It's recommended that you use Visual Studio Community edition if you do not already have Visual Studio.

## Backlog

### Bug #1: Movies are not sortable
Currently, the movies are unable to be sorted. There are UI links in place to trigger a sort, but they do nothing. When complete, each link should be able to sort the data by their respective columns.

Some of the titles have leading articles (a/an/the). When sorting by title, provide a mechanism that excludes the leading articles, so that only the portion of the title following the article is matched on when sorting. For example, when the movie title "The Terminator" is included in the sortable list, only the title portion "Terminator" should be evaluated.

> Note: There are also unit tests wired to the sort methods on the LibraryService which currently fail. When this is corrected, each unit test should pass.

### Bug #2: Remove duplicate movies
Currently, there are movies in the library which are duplicated by Title. They show in the UI as a duplicate. Without physically removing the entries from the data store(library.xml), ensure that they no longer show in the UI.

### Request #1: Filter movies by title
Currently, the Movie Library page shows all movies within the library. Implement functionality that allows the user to search movies by title.

### Request #2: Show movies by franchise
A number of movies in the library belong to a franchise (for instance, Star Wars IV, V, & VI all belong to the Star Wars franchise). Update the Movie Library page so that the franchises are shown. The franchises should also be sortable.

> Note: The list of movies and what franchise they belong to are included in the UI Project under MovieFranchises.txt.

### Request #3: Implement a movie library API
Using whichever technology, pattern, and practice you feel is appropriate, implement a Movie Library API which may return any number of the following results:
1. Movies in the library, filtered by title
2. Movies that are above or below a certain Rating
3. Movies between a date range
4. Movies belonging to a given franchise

### Technical Debt #1: Unit test library doesn't implement IoC
The Web Application properly implements the StructureMap IoC library; however, the Unit Test project does not. Implement StructureMap IoC within the Unit Test project.

### Request #4: Improve UI performance by implementing a JavaScript UI framework
Currently, the web application renders using MVC and Razor. Implement a basic UI framework of your choice (ReactJS, Angular, etc) so that the screens sort, filter, and page without reloading the entire screen.

> Note: Bonus points if Request #1 (filtering by title) auto-refreshes as the user types.