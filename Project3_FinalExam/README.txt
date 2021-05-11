READ ME

Alexis Gordon and Mason Lapine
Final Project 3
5-10-2021


WHAT WE DID
++++++++++++++++++++++++++++++++++++++++++++++++
1. Added RIT API Data using Dependency Injection
++++++++++++++++++++++++++++++++++++++++++++++++
Each data piece gotten from the api generates a new service in startup.cs that calls on the 
associated Get class which implements an abstract IGet class. This class calls upon an async Task.

Home Page
- Pulls 6 photos from RIT's dropbox and generates a slidejs slideshow for them
- /about
	- Pulls title, description, quote, and the author of the quote

Faculty Page
- /people/faculty
	- Pulls the faculty member's image, name, username, office, email, phone number, and title
	- On click, displays the faculty information via a jQuery UI Dialog box

Undergraduate Degrees Page
- /degrees/undergraduate
	- Pulls each degree's name, title, description, and concentrations
	- Arranges undergraduate degrees via a jQuery UI accordian

Graduate Degrees Page
- /degrees/graduate
	- Pulls each degree's name, title, description, and concentrations
	- Arranges graduate degrees via a jQuery UI accordian

Undergraduate Minors Page
- /minors
	- Pulls each minor's name, title, description, courses, and note
	- Arranges undergraduate minors via a jQuery UI accordian

Employment Page
- /employment/employmentTable
	- Pulls each entry's employer, degree, city, title, and start date
	- Arranges data via a jsGrid
	- Arranges additional degree data via a Chart.js

Co-op Page
- /employment/coopTable
	- Pulls each entry's employer, degree, city, and term
	- Arranges data via a jsGrid



++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
2. Extra Implementation Using slidesjs slideshow, jQuery UI (accordian and dialog), jsgrid, and Chart.js
+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
slidesjs
- Home Page Images (EXTRA CREDIT)

jQuery UI Accordian
- Degrees and Minors 

jQuery UI Dialog
- Faculty

jsGrid
- Employment and Co-op Tables (EXTRA CREDIT)

Chart.js
- Employment Degree Data (EXTRA CREDIT)



