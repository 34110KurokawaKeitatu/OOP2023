using System;
using System.Collections.Generic;
using System.IO;

namespace Test01 {
    public class ScoreCounter {
       private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(String filePath) {

            _score = ReadScore(filePath);

            
        }


        //メソッドの概要： StudentScoreを読み込み、Studentオブジェクトのリストを返す
        public static IEnumerable<Student> ReadScore(string filePath) {
            var scores = new List<Student>();
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var items = line.Split(',');
                var score = new Student
                {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                 scores.Add(score);
            }
            return scores;





        }

        //メソッドの概要： 科目別に集計して求める
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new SortedDictionary<string, int>();
            foreach(var score in _score)
            {
                if (dict.ContainsKey(score.Name))
                {
                    dict[score.Name] += score.Score;
                }
                else
                {
                    dict[score.Name] = score.Score;
                }
               
            }


            return dict;


        }
    }
}
