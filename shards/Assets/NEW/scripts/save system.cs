using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class savesystem {

   public static void SavePlayer (playerStats player)
   {
    BinaryFormatter formatter = new BinaryFormatter();
    string path = Application.persistentDataPath + "/player.save";
    FileStream stream = new FileStream(path, FileMode.Create);

    save data = new save(player);

    formatter.Serialize(stream, data);
    stream.Close();
   }

   public static save LoadPlayer ()
   {
    string path = Application.persistentDataPath + "/player.save";
     if (File.Exists(path))
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(path, FileMode.Open);

        save data = formatter.Deserialize(stream) as save;
        stream.Close();

        return data;

    }
    else;
    {
        Debug.LogError("Save file not found in" + path);
        return null;
    }

}
}
