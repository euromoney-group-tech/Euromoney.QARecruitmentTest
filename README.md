## Intro

Hello. Thank you for taking the time do our tests. It's made up of two parts, a UI test and an API test. We have created blank projects with references for [NUnit](http://www.nunit.org), [Specflow](http://specflow.org/) and [Selenium WebDriver](http://www.seleniumhq.org/docs/03_webdriver.jsp) using [NuGet](http://nuget.codeplex.com/) Packages. 

Feel free to use any other packages you think will help demonstrate your test writing skills.



---

## UI Test

Using C# write automated functional tests for the following user stories using Selenium and Specflow with the use of the page object pattern where possible
- The site to test is http://www.euromoneyplc.com/
- Any browser can be used for the purpose of this task.



### Story 1

In order to **promote our management team**
As a **user**
I want to **view a list of the management team**

#### Acceptance criteria

- Management team page is displayed correctly
- Verify that all team members have Name, Job Title, Picture and description.

#### Notes

- The management team page location is **menu --> 'Who we are' --> 'Management team'
- The HTML tags are missing IDs so using the tag text is acceptable

### Story 2

In order to **promote out portfolio**
As a **user**  
I want to **view a list and navigate to other brands**


#### Acceptance criteria

- The ‘Specialist finance and economic data’ link is displayed correctly on the menu item
- The ‘VISIT IJ GLOBAL’ link navigates to https://ijglobal.com/
- The page title is ‘IJGlobal | Infrastructure Journal and Project Finance Magazine’
- The league table section is displayed on the home page

#### Notes

- The portfolio page location is **menu --> 'Our Portfolio' --> 'Pricing, data and market intelligence'
- The HTML tags are missing IDs so using the tag text is acceptable

---

## API Test

Using Google Tasks API https://developers.google.com/google-apps/tasks/ write tests for the following scenarios using C#, NUnit.  


1. Create a new task list and check the new task list is returned by GET tasklists.  
2. Create three tasks in the new task list and check the new tasks are returned by GET tasklist.  
3. Mark one task as completed and check if the task is returned by GET tasklist.  
4. Delete another task and check if the task is not returned by GET tasklist. 
5. Mark the last task as hidden and check if the task is not returned by GET tasklist.  
6. Call tasks.clear and check if no tasks are returned by GET tasklist.  
7. Call GET tasklists with showhidden = true and showdeleted = true and check that all tasks a returned.  
8. Delete the tasklist and check if it is not returned by GET tasklists.  
