# Jobs Portal Server
Server side of jobs portal app using .Net 6 (.net core) web apis and entity framework with authentication and authorization flows handeled by jwt and roles.

## Main Functionality
- Guest can view available jobs.
- Guest can sign up to create an account.
- User can signin to apply for jobs.
- User can View jobs he/she applied for.
- User cannot apply for job when it is expired.
- Admin can add/edit/delete jobs.
- Job Expired when its date is not available anyore.
- Job Stops accepting applications when its reach maximum applicant number.



## Notes
- Admin login Credentials (to edit/add/delete jobs ).
  - **UserName: admin** 
  - **Password : admin** 
- Database is hosted so no need to change ConnectionString
