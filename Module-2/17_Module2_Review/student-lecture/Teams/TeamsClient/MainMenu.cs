using MenuFramework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using TeamsClient.Models;

namespace TeamsClient
{
    public class MainMenu : ConsoleMenu
    {
        string baseApiUrl;
        RestClient client;
        public MainMenu(string baseApiUrl)
        {
            this.baseApiUrl = baseApiUrl;
            this.client = new RestClient(baseApiUrl);
            AddOption("List All Teams", ListAllTeams);
            AddOption("Exit", Exit);
        }

        private MenuOptionResult ListAllTeams()
        {

            //create a restrequest to the /team url. get back a list of Team
            RestRequest request = new RestRequest("teams");

            //display the teams to the user
            IRestResponse<List<Team>> response = client.Get<List<Team>>(request);
            List<Team> teams = response.Data;
            foreach(Team team in teams)
            {
                Console.WriteLine($"{team.TeamName}");
            }
            return MenuOptionResult.WaitAfterMenuSelection;
        }
    }
}
