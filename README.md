# Refactoring-Improving-The-Desgin-Martin-Fowler
# Chapter 2 ( Principle in Refactoring )
- Refactor improves the deso=ign of the software
- Refactor makes software easier to understand
- Refactor help you to find bugs
- refactor help you prgram faster
# When you sholuld refactor ?
- should we allocate two weeks every couple of months to refactoring ?
- No you refactor because you want to do something and refactoring helps you do that other things
# three strikes and you refactor 
. Refactor when you add fuction 
. Refactor when you need to fix a bug
. Refactor as you do a code review
# Problems with refactoring
. Database 
change the database schema force you to migrate the data so to deal with this problem you need to seperate layer of software
between your object model and your databse model .
As you update one model you don't need to update another you just update an intermediate layer . such this layer add more complexity but give
you more flexiability 
# When shouldn't you refactor ?
when you need to create a code from scratch . 
when you are close to the deadline . At this point the productivity again from refactoring would appear after the deadline and thus be too late .

# Cahpter 3 ( Bad Smells in Code )
. Deciding when to start refactoring and when to stop . is just important to refactorying as knowing how to operate the mechanism of a refactoring
1 - Duplicated Code : when you have the same expression in two methods of the same class . Then all you need to do is extract the method and invoke the code from both places
 - Another common duplication problem when you have the same expression in two sibling subclasses . you can eliminate this duplication by using **Extracting method**
 in both class then **pull up method**
 
2 - Long Mehthod
. The object programs that live best and longest are those with short methods .

3 - Large Class
. when a class is trying to doo too much , it often show ups as too many instance variable => when class has too many instance variables , duplicated code can't be far behing.

4 - Long Parameter List 
. we were taught to pass in as parameter every thing needed by routine . this was understandable because the alternative was global data and global data is evil and usually painful  . object change this situation because if you don't have something you need you can always as another object to get it for you 
thus with objects you don't pass in everything the method needs
In object Oriented Programs parameter lists tend to be mush smaller than in traditional programs 

5 - Divergent Class
we structure our software to make change easier . after all, software is meant to be soft . when we make a change we want to able to jump ti a single clear point in the system and make the change 

6 - Feature Envy
. The whole point of objects is that they are a technique to package data with the process used on that data . 
A **Classic Smell is a method that seems more interested more other than the one actually is in**

7 - Data Clumps
. Data items tends to be like childern ; they enjoy hanging aroud in groups together.  often you see three or four data items together in lots of places 

8 - Switch Statment 
one of the most obvious symptoms of object oriented code is it's comparative lack of switch ( Or case ) statment . the problem of switch statment is essentially that duplication . often you find many switch statment in many places => so if you add a new clause to the switch you have find all these switch statment and change them . the object oriented notion of polymporphysim gives you an elegant way to deal with this problem 

**Most times you see a switch statment you should consider polymorphsim** 
**the problem is where the polymorphysim gives**

9 - Parallel Inheritance Hierarchies . 
. Every time you make a subclass of one class ,  you also have to make a subclass of another . you can recongize this smell becasue the prefix of the class 
name in one hirerchy are the same as the prefix in another hirearchy .
** To Prevent this problem ** 
the instance of one hierarchy refer to instance of one hierarchy refer to instances of the other . 
**Using Move Method & Move Field prevent this happened**
10 - Message Chain 
You see message chain when a clinet asks one object for another object , which the client then asks for yet another object , which the clien then asks for yet another another object .
Navigation this way means the client is coupled to the structure of the navigation 

11 - Middle Man 
. one of the prime features of object is encapsulation - hidding internal details from the reset of the world . 
Encapsulation often come with delegation . 

12 - Refused Bequest 
Subclasses get to inherit the methods and data of their parents . but what if they don't want or need what are given ? they are given all theses great gifts and pic just a few to play with .
So you need to create new sibling class and use **Push Down Method** and **Push Down Fields**
to push all unused methods to the sibling .

# Chapter 4 : Building Tests
if you want to refactor you ,  the essential precondition is having solid tests . I don't see as a disadvantage. I have found that writing good tests greatly speeds my programming even if I'm not refactoring .
* every developer spend much time to find the bug fixing the bug not take much time as finding it . and when you fix the bug maybe happened another bug in your system and you finds it while time .
so each class should have it's own method ( called test ) .
so i started to run tests every time i compiled . soon i began to notice my productivity 
had shot upward i realized that I wasn't spending so much time debugging if I added a bug that was caught by a previous test . it would show up as soon as possible 
not just had i built self-testing classes , but by running them frequently i had powerful bug detector .
with the time i'm being more aggressive about the writing unit tests immediately not waiting for the end to increment , i would add the tests immediately after writing a bit function .
every day i would add two couple of features and the tests to test them , these days I hardly ever spend more than a few minutes debugging .
*Note : One of the most useful times to write tests is before you start programming . when you add new features just begin writing the test.**
this isn't backward as its sound . by writing the test you are asking yourself what  need to be done to add the function .

**Differnet between unit test and functionality test**
**unit test** : write unit test eo improve the productivity as programmer . making the quality assurance department happy . Each test class works within a single package . it tests the interfaces to other package but beyond that it assumes the rest just works .
**Functional Test**: it's used to check the software as whole works . they provide quality assurance to the customer and don't care about programmer productivity . it's treat the whole system as black box as much as possible 
**Note : when you get a bug start to write unit test that expose the bug**
