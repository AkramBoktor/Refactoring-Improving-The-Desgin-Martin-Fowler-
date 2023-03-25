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



