using projeto_es.Models;

namespace projeto_es.Business_Layer
{
    public class LoginFacade
    {
        private LoggedInSingleton LoggedSingleton { get; set; }

        public LoginFacade(LoggedInSingleton loggedSingleton)
        {
            LoggedSingleton = loggedSingleton;
        }

        public void Login(AccountService accountService, Account account, string email, int id)
        {
            Person personAssociatedToAccount = accountService.GetUserDataFromAccount(email);
            LoggedSingleton.clientID = accountService.GetClientAccountId(id);

            Person staffAssociatedToAccount = accountService.GetStaffDataFromAccount(email);
            LoggedSingleton.staffID = accountService.GetStaffMemberID(id);

            Person adminAssociatedToAccount = accountService.GetAdminDataFromAccount(email);
            LoggedSingleton.adminID = accountService.GetAdminMemberID(id);

            atributeSession(personAssociatedToAccount, staffAssociatedToAccount, adminAssociatedToAccount , account);
        }
        private void atributeSession(Person personAssociatedToAccount, Person staffAssociatedToAccount, Person adminAssociatedToAccount, Account account)
        {
            if (LoggedSingleton.clientID == 0)
            {
                if (LoggedSingleton.staffID != 0)
                {
                    LoggedSingleton.Account = account;
                    LoggedSingleton.Person = staffAssociatedToAccount;
                    LoggedSingleton.Role = "Staff";
                }
                else
                {
                    LoggedSingleton.Account = account;
                    LoggedSingleton.Person = adminAssociatedToAccount;
                    LoggedSingleton.Role = "Admin";
                }
            }
            else
            {
                LoggedSingleton.Account = account;
                LoggedSingleton.Person = personAssociatedToAccount;
                LoggedSingleton.Role = "Client";
            }
        }
    }
}
