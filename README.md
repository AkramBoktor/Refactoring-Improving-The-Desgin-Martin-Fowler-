# Refactoring Improving The Desgin ( Martin Fowler )
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
if you want to refactor you ,  the essential precondition is having solid tests . 
I don't see as a disadvantage. I have found that writing good tests greatly speeds my programming even if I'm not refactoring .

every developer spend much time to find the bug fixing the bug not take much time as finding it . and when you fix the bug maybe happened another bug in your system and you finds it while time .

so each class should have it's own method ( called test ) .
so i started to run tests every time i compiled . soon i began to notice my productivity 
had shot upward i realized that I wasn't spending so much time debugging if I added a bug that was caught by a previous test . it would show up as soon as possible 
not just had i built self-testing classes , but by running them frequently i had powerful bug detector .
with the time i'm being more aggressive about the writing unit tests immediately not waiting for the end to increment , i would add the tests immediately after writing a bit function .

every day i would add two couple of features and the tests to test them , these days I hardly ever spend more than a few minutes debugging .
**Note : One of the most useful times to write tests is before you start programming . when you add new features just begin writing the test.**
this isn't backward as its sound . by writing the test you are asking yourself what  need to be done to add the function .

**Differnet between unit test and functionality test**
**unit test** : write unit test eo improve the productivity as programmer . making the quality assurance department happy . Each test class works within a single package . it tests the interfaces to other package but beyond that it assumes the rest just works .
**Functional Test**: it's used to check the software as whole works . they provide quality assurance to the customer and don't care about programmer productivity . it's treat the whole system as black box as much as possible 
**Note : when you get a bug start to write unit test that expose the bug**

# Cahpter 5 : Toward a catalog of refactorings 
Format of refactorings .  each refactoring has five parts as follow

1 - **Name** : the name is important to building vocabulary of refactorings .

2 - **Short Summary** : Following the name with a short summary if the situation in which you beed the refactorung and a sumaary of what the refactoring does . this help you to find the refactoring moew quickly .

3 - **Motivation** : the motivation describes why the refactoring should be done and describe circumstances in which it should't be done .

4 - **Mechanics** : step by step description of how to carry out the refactorying

5 - **The examples** : show a very simple use of the refactoring to illustrate how it works .

# Cahpter 6 Compassing Methods
*Almost all the time the problems come from methods that are too long*
**Extract Method** : which takes a clump of code and turns it into its own method 
**Inline Method** : The opposite you take a method call abd replace it with the body of the code 

```ruby
 public class Extract_Method
    {
        public void Main()
        {
            printOwing(100);
            printOwingRefactor(1010);
        }


        #region Before Extract Method
        public void printOwing(double amount)
        {
            printBanner();
            Console.WriteLine("name " + "Akram");
            Console.WriteLine("Amount " + amount);
        }

        private void printBanner()
        {
            Console.WriteLine("*** Banner ***");
        }
        #endregion

        #region With Extract Method 

        public void printOwingRefactor(double amount)
        {
            printBannerRefactor();
            printDetailsRefactor(amount);


        }

        private void printBannerRefactor()
        {
            Console.WriteLine("*** Banner Refactor ***");
        }

        private void printDetailsRefactor(double amount)
        {
            Console.WriteLine("name Refactor " + "Akram Refactor");
            Console.WriteLine("Amount Refactor " + amount);
        }
        #endregion
    }
  ```    
   
    
  **Motivation** : Extract Method is one of the most common refactorings i do . I look at the method that is too long or look at code that needs a comment to understand its purpose . I then turn that fragement of code into its own method .
  **Prefer** : - Short - well named method for serval reasons 
  1 - it increases the chances that other methods can use a method when the methid is finely gained 
  2 - it allows the higher-level methods to read more like series of comments
  
  **Mechanics**
  1 - Create a new method , and name it after the intention of the method ( name it by **what** it does , not by **how** it it does )
  -> if the code you want to extract is very very simple , such as single message or function call , you should extract it if the name of the new method will **Reveal the intention** of the code in a better way **if you can't come up with a more meaningful name , don't extract the code .**
  
  2 - Copy the extracted code from the source method into the new target method .
  
  3 - scan the extracted code for references to any variables that are local in scope to the source method . these are local variables and parameters to the method .
  
  4 - see whether any temporary variables are used only within this extracted code . if so declear them as temporary variables

  5 - pass into the target method as parametrs local scope variables that are read from the extracted method .
  
  6 - compile when you have dealt with all the locally scoped variables .
  
  7 - Replace the extracted code in the source methid with a call to the target method .
  
  -> if you have moved any temporary variables over the target method ,  look to see whether they were declared outside of the extracted code , if so you can now remove the declearation
  
  8 - Compile test
  
  **using local variables when make Extract Method** 
  the problem is local variables : parameter passed into the original method and temporaries declared within the original method .
  Local variables are only in scope in that method so when i use **Extract Method** these variables cause extra work . In some case they even prevent me from doing the refactoring at all.
  
**Inline Method** :  A method's body is just as clear as its name.

**put the method's body into the body of its callers and remove the method .

```ruby
   public class InlineMethod
    {
        public void Main()
        {
            Console.WriteLine(getRating());
            Console.WriteLine(getRatingAfter());
        }

        #region Before Inline Method
        // *Inline Method** :  A method's body is just as clear as its name.
        // put the method's body into the body of its callers and remove the method .
        public int getRating()
        {
            int rate = 5;
            return (moreThanFiceLateDeliveries(rate)) ? 2 : 1;
        }

        private bool moreThanFiceLateDeliveries(int number)
        {
            return number > 5;
        }
        #endregion

        #region After Inline Method
        // *Inline Method** :  A method's body is just as clear as its name.
        // put the method's body into the body of its callers and remove the method .
        public int getRatingAfter()
        {
            int rate = 5;
            return (rate > 5) ? 2 : 1;
        }
        #endregion
    }
```

**Mechanics**

1 - Check that the method isn't polymorphic 

*Don't inline if subclass ovrerride the method ; they cann't override a methid that isn;t there 

2 - find all calls to the method 

3 - Replace each call with the method body . 

4 - Compile and test . 

5 - remove the method definition .

**Replace Temp With Query** :

You are using a temporary variable to hold the result of an expression. 

**Extract the expression into a method . replace all reference to the temp with the new method . the new method can then br used in other methods.

```ruby
public class ReplaceTempWithQuery
    {
        public void Main()
        {
            Console.WriteLine(CalculateMethod());
            Console.WriteLine(CalculateMethodAfter());
        }

        #region Before Replace Temp With Query
        // Extract the expression into a method . replace all reference to the temp with the new method .
        // the new method can then br used in other methods.
        public double CalculateMethod()
        {
            ///// Before Replace Temp With Query
            Console.WriteLine("*** Before Replace Temp With Queryr ***");

            double basePrice = 10 * 5;
            if (basePrice > 1000)
                return basePrice * 10;
            else
                return basePrice * 0;
        }
        #endregion

        #region After Replace Temp With Query
        // this simple example case extract the method (110) is trivially easy 
        public double CalculateMethodAfter()
        {
            ///// Before Replace Temp With Query
            Console.WriteLine("*** After Replace Temp With Queryr ***");


            if (basePrice() > 1000)
                return basePrice() * 10;
            else
                return basePrice() * 0;
        }

        private double basePrice()
        {
            return 10 * 5;

        }
        #endregion
    }
```

**Introduce Explaining Variable**

*You have a complicated experssion 
put the result of the expression , or parts of the experssion , in a temprary variable with a name that explain the purpose 

```ruby
if(( platform.toUppercase().index("Mac") > -1 ) && ( browser.toUppercase().index("IE") > -1 ) && WasIntialize() && resize > 0 )
{
 // Do Something
}

we will change it as 

bool isMac = platform.toUppercase().index("Mac") > -1 ;
bool isBrowser = browser.toUppercase().index("IE") > -1 ;
bool wasResize = WasIntialize() && resize > 0 ;

if( isMac && isBrowser && wasResize){
  //Do Something
}
```
**Motivation**

Expression can become more complex and hard to read. In such situation temporary variables can be helpful to break down the expression into something more manageable.

**Mechanics**

1 - Decleare a final temporary variable , and set it to the result of part of the complex expression 

2 - Replace the result part of the expression with the value of the temp .

=> of the result part of the expression is repeated. you can replace the repeats one at a time .

3 - compile and test 

4 - Repeat for other parts of the expression . 


```ruby
 public class ExampleExtractMethod
    {
        public void Main()
        {
            Console.WriteLine("ExampleExtractMethod " + Price());
            Console.WriteLine("ExampleExtractMethod " + PriceAfter());
        }


        #region Before Extract Method
        public double Price()
        {
            return 10 * 5 - Math.Max(0, 10 - 500) * 5 * 0.05 + Math.Min(10 * 5 * 0.1, 1000);
        }
        #endregion

        #region With Extract Method 

        public double PriceAfter()
        {
            return basePrice() - quantityPrice() + shipping();


        }

        private double basePrice()
        {
            return 10 * 5;
        }

        private double quantityPrice()
        {
           return Math.Max(0, 10 - 500) * 5 * 0.05;
        }
        private double shipping()
        {
            return Math.Min(10 * 5 * 0.1, 1000);
        }
        #endregion
    }
    
```

# Remove Assignments to parameters

*The code assigns to a parameter use a temporary variable instead.

```ruby
int discount(int inputval , int quantity , int yearToDate){
if(inputval > 50 ) inputval = -2 ;
}
|
int discount(int inputval , int quantity , int yearToDate){
int result = inputval ;
if(inputval > 50 ) result = -2 ;
}
```

**Mechanics**

1- Create a temporary variable for the parameters

2- Replace all references to the parameter, made after the assignment , to a temporary variable 

3- Change the assignment to assign to the temporary variable .

4- Compile and test


# Substitute Algorithm
``` ruby
 public class Substitute_Algorithm
    {
        public void Main()
        {
            Console.WriteLine(FoundPerson(new string[] { "Don","test","test3" }));
            Console.WriteLine(FoundPersonAfter(new string[] { "John", "test", "test3" }));
        }

        #region Before Substitute_Algorithm  
        
        public string FoundPerson(string[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].Equals("Don"))
                {
                    return people[i];
                }
                if (people[i].Equals("John"))
                {
                    return people[i];
                }
                if (people[i].Equals("Kent"))
                {
                    return people[i];
                }
            }
            return string.Empty;
        }
        #endregion

        #region After Substitute_Algorithm 
        public string FoundPersonAfter(string[] people)
        {
            List<string> candiares = new List<string> { "Don", "John", "Kent" };
            for (int i = 0; i < people.Length; i++)
            {
                if (candiares.Contains(people[i]))
                    return people[i];
            }
            return string.Empty;
        }
        #endregion
    }
```

# Move Method

* A method is,or will be, using or used by more features of another class than the class on which it is defined .
* Create a new method with a similiar body in the class it uses most . Either turn the hold method into a simple delegation , or remove it altogether .

**Motivation**
Moving methods is the bread and butter of refactoring . i move methods when classes have too much behavior oe when classes are collaboration too much and are too highly coupled . by moving methods around i can make the classes simpler and they end up being more crisp implementation of a set of responsibilites .

```ruby
class Acount ... 
{
     private AccountType _type;
     private int _daysOverdrawn;

     double overdraftCharge(){
     if(_type.isPremium()){
     double result = 10;
     if(_daysOverdrawn > 7 ) result+= _daysOverdrawn - 7  * 0.85 ;
     return result ;
     }
     else return _daysOverdrawn * 1.75 ;
     }

     double bankCharge(){
     double result = 4.5 ;
     if(_daysOverdrawn > 0 ) result += overdraftCharge();
     return result;
     }
}

/* After Using Move Method approch */
class AcountType ... 
{
     private int _daysOverdrawn;

     double overdraftCharge(int daysOverdrawn){
     if(**isPremium()**){
     double result = 10;
     if(**daysOverdrawn** > 7 ) result+= **daysOverdrawn** - 7  * 0.85 ;
     return result ;
     }
     else return _daysOverdrawn * 1.75 ;
     }

}

the super class will be 
class Account...{
     private int _daysOverdrawn;

   double overdraftCharge(){
 return _type.overdraftCharge(_daysOverdrawn)
  }
  
    double bankCharge(){
     double result = 4.5 ;
     if(_dayOverdrawn > 0 ) result += _type.overdraftCharge(_daysOverdrawn);
     return result;
     }
}
```
Once I've replaced all the callers , i can remove the method decleration in account . i can compile and test after each removal , or do then in a batch . if the method isn't private , I need to look for other classes that use this method . In a strongly typed language , the compilation after removal of the source decleration finds anything missed .

# Move Field
A field is , or will be used by another class more than the class on which it's defined 
create a new field in the target class and change all it's users

**Mechanics**
1 - if the field is public , use Encapsulate field 

2 - compile and test

3 - create a field in the target class with getting and setting method

4 - compile the target class 

5 - Determine how to reference the target object from the source 

6 - Remove the field on the source class

7 - replace all reference to the sorce field with regerence to appropriate method on the target

8 - compile and test 

# Example

```ruby
Public class Account {
  
  private AccountType _type;
  private double _interestRate
  
  public double intersetForAmount_days(double amount , int days){
   
           return _interestRate * amount * days / 365 ;
  }
}
```
I want to remove interest rate field to the account type . there are serveral method with the reference of which *interestForAmount_days* is one example .

``` ruby
public class AccountType {
  
     private double _interestRate ;
     
     void setInterestRate (double args ){
        
          _interestRate = args;
    }
    
    double getIntersetRate() {
       _return _intersertRate;
    }
}
```
I can compile the new class at this point . 
No I redirect the methods froms the account class to use the account type and remove the interest rate field in the account . I must remove the field to be sure that the redirection is actually happening . this way the compiler helps spots and method I failed to redirect .

```ruby
    private double _interest;
    
    double interestForAmount_days ( double amount , int days) {
      return _type.getIntersetRate() * amount * days / 356 ;
    }
```
# Example: Using Self-Encapsulation 
if alot of methods use the interest rate field , i might start by using Self-Encapsulation field

``` ruby
public class Account {
       
        private AccountType _type;
        private double _interestRate;

        double intersetForAmount_days ( double amount , int days ) {
             return getIntersetRate() * amount * days / 365;
        }

        private void setIntersetRate ( double arg ){
          _interestRate = arg;
       }
        private double setIntersetRate (){
          return _interserRate ;
       }
 }

```
That way I only need to do the redirection for accessors : 

``` ruby
double intersetForAmountAndDays (double amount , int days) {
   return getInterestRate() * amount * days / 365 ;
}

private void setIntersetRate (double arg) {
         _type.setInterestRate(arg)  ;      
}
private double getIntersetRate () {
     return _type.setInterestRate(arg)  ;      
}
```
