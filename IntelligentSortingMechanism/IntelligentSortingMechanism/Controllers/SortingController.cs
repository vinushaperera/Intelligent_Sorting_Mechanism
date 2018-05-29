using IntelligentSortingMechanism.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentSortingMechanism.Controllers
{
    public class SortingController
    {
        List<TaskModel> ex_tasks;

        public Dictionary<int, List<TaskModel>> SortingHandler(List<TaskModel> tasks)
        {            
            tasks = RemainingDaysCalc(tasks);
            tasks = InitSorting(tasks);
            Dictionary<int, List<TaskModel>> final_list =  NonDominatedSorting(tasks);

            return final_list;
        }

        public List<TaskModel> RemainingDaysCalc(List<TaskModel> tasks)
        {
            DateTime today = DateTime.Now;

            foreach (TaskModel item in tasks)
            {
                item.Rem_days = (int)item.Task_deadline.Subtract(today).TotalDays;
            }

            return tasks;
        }

        public List<TaskModel> InitSorting(List<TaskModel> tasks)
        {
            int initial_counter = 0;
            int no_of_tasks = tasks.Count;

            bool swapNeeded = true;

            while (initial_counter < no_of_tasks - 1 && swapNeeded)
            {

                swapNeeded = false;

                for (int index = 1; index < no_of_tasks; index++)
                {
                    if (tasks[index - 1].Task_priority > tasks[index].Task_priority)
                    {
                        TaskModel temp = tasks[index - 1];
                        tasks[index - 1] = tasks[index];
                        tasks[index] = temp;
                        swapNeeded = true;
                    }
                    else if (tasks[index - 1].Task_priority == tasks[index].Task_priority)
                    {
                        if (tasks[index - 1].Rem_days > tasks[index].Rem_days)
                        {
                            TaskModel temp = tasks[index - 1];
                            tasks[index - 1] = tasks[index];
                            tasks[index] = temp;
                            swapNeeded = true;
                        }
                    }
                }

                if (!swapNeeded)
                {
                    break;
                }

                initial_counter++;
            }

            return tasks;
        }

        public Dictionary<int, List<TaskModel>> NonDominatedSorting(List<TaskModel> tasks)
        {
           

            int fronts_identified = 0;

            Dictionary<int,List<TaskModel>> fronts_list = new Dictionary<int, List<TaskModel>>();

            foreach (TaskModel item in tasks)
            {
                if(fronts_identified == 0)
                {
                    List<TaskModel> f1 = new List<TaskModel>();
                    f1.Add(item);

                    fronts_list.Add(fronts_identified, f1);
                    fronts_identified++;
                }
                else
                {
                    int total_fronts = fronts_identified;
                    bool nondominated = false;

                    for (int count1 = 0; count1 < total_fronts; count1++)
                    {
                        List<TaskModel> temp_list = fronts_list[count1];
                        int count_tasks = temp_list.Count;

                        for (int count2 = count_tasks - 1; count2 >= 0; count2--)
                        {
                            int prScore = temp_list[count2].Task_priority - item.Task_priority;
                            int dScore = temp_list[count2].Rem_days - item.Rem_days;
                            int score = prScore + dScore;

                            if (score >= 0)
                            {
                                nondominated = true;
                                temp_list.Add(item);
                                break;
                            }
                            else if (score < 0)
                            {
                                nondominated = false;
                            }                          

                        }

                        if (nondominated)
                        {
                            break;
                        }
                    }

                    if (!nondominated)
                    {
                        List<TaskModel> new_front = new List<TaskModel>();
                        new_front.Add(item);

                        fronts_list.Add(fronts_identified, new_front);
                        fronts_identified++;
                    }
                }

            }
            

            return fronts_list;
        } 
        
    }
}
