using System;
using System.Collections.Generic;
using Military_Elite.Models;
using Military_Elite.Interface;
using Military_Elite.Enums;

namespace Military_Elite
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, ISoldier> military = new Dictionary<string, ISoldier>();
            string line = Console.ReadLine();
            while (line != "End")
            {
                string[] data = line.Split();

                string type = data[0];

                string id = data[1];
                string firstName = data[2];
                string lastName = data[3];

                if (type == nameof(Private))
                {
                    decimal salary = decimal.Parse(data[4]);
                    military.Add(id, new Private(id, firstName, lastName, salary));

                }
                else if (type == nameof(LieutenantGeneral))
                {
                    decimal salary = decimal.Parse(data[4]);
                    ILieutenantGeneral tempGeneral = new LieutenantGeneral(id, firstName, lastName, salary);
                    for (int i = 5; i < data.Length; i++)
                    {
                        string tempId = data[i];
                        if (military.ContainsKey(tempId) == false)
                        {
                            continue;
                        }

                        tempGeneral.AddPrivate((IPrivate)military[tempId]);
                    }
                    military.Add(id, tempGeneral);
                }
                else if (type == nameof(Engineer))
                {
                    decimal salary = decimal.Parse(data[4]);
                    bool isCorpValid = Enum.TryParse(data[5], out Corps corp);
                    if (isCorpValid == false)
                    {
                        line = Console.ReadLine();
                        continue;
                    }
                    IEngineer tempEngineer = new Engineer(id, firstName, lastName, salary, corp);

                    for (int i = 6; i < data.Length; i += 2)
                    {
                        string partName = data[i];
                        int hoursWorked = int.Parse(data[i + 1]);
                        IRepairs tempRepair = new Repairs(partName, hoursWorked);
                        tempEngineer.AddRepair(tempRepair);
                    }

                    military.Add(id, tempEngineer);
                }
                else if (type == nameof(Commando))
                {
                    decimal salary = decimal.Parse(data[4]);
                    bool isCorpValid = Enum.TryParse(data[5], out Corps corp);
                    if (isCorpValid == false)
                    {
                        line = Console.ReadLine();
                        continue;
                    }
                    ICommando tempCommando = new Commando(id, firstName, lastName, salary, corp);

                    for (int i = 6; i < data.Length; i += 2)
                    {
                        string codeName = data[i];
                        string status = data[i + 1];
                        bool isMissionValid = Enum.TryParse(status, out Status result);
                        if (isMissionValid == false)
                        {
                            continue;
                        }
                        IMissions tempMission = new Mission(codeName, result);
                        tempCommando.AddMission(tempMission);

                    }
                    military.Add(id, tempCommando);
                }
                else if (type == nameof(Spy))
                {
                    int codeNumber = int.Parse(data[4]);
                    ISpy currentSpy = new Spy(id, firstName, lastName, codeNumber);

                    military.Add(id, currentSpy);
                }
                line = Console.ReadLine();
            }

            foreach (var item in military)
            {
                Console.WriteLine($"{item.Value}");
            }
        }
    }
}
