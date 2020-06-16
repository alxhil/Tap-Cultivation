using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class dbManager{

    public static string username;
    public static int spiritstone;
    public static int cultivationRank;
    public static int totalspiritStones;
    public static int reincarnationLevel;

    public static bool LoggedIn {  get { return username != null;  } }
	
    public static void LogOut()
    {
        username = null;
    }

}
