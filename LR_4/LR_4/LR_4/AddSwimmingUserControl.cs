﻿using model;
using model.Exercises;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LR_4
{
    /// <summary>
    /// 
    /// </summary>
    public partial class AddSwimmingUserControl : UserControl, IAddExercises
    {

        /// <summary>
        /// Словарь UserControls
        /// </summary>
        private readonly Dictionary<string, SwimmingStyle>
            _comboBoxStyle;

        /// <summary>
        /// Добаление плавания
        /// </summary>
        public AddSwimmingUserControl()
        {
            InitializeComponent();

            string[] swimmingStyle = { "Кроль", "Брасс", "Баттерфляй",
                "Аквааэробика"};

            comboBox_Style.Items.AddRange(new string[]
                 { swimmingStyle[0], swimmingStyle[1],
                     swimmingStyle[2], swimmingStyle[3]});

            _comboBoxStyle = new Dictionary<string, SwimmingStyle>()
            {
                {swimmingStyle[0], SwimmingStyle.Crawl},
                {swimmingStyle[1], SwimmingStyle.Breaststroke},
                {swimmingStyle[2], SwimmingStyle.Butterfly},
                {swimmingStyle[3], SwimmingStyle.WaterAerobics}
            };
        }

        /// <summary>
        /// Контроль ввода значений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlText.CheckInput(e);
        }

        /// <summary>
        /// Контроль ввода значений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Time_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlText.CheckInput(e);
        }

        /// <summary>
        /// 
        /// </summary>
        //private SwimmingStyle _swimmingStyle = SwimmingStyle.Defult;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Swimming_SelectedIndexChanged(object sender, EventArgs e)
        {
            SwimmingStyle _swimmingStyle = SwimmingStyle.Defult;
            string style = comboBox_Style.SelectedIndex.ToString();
            foreach (var (item, swimmingStyle) in _comboBoxStyle)
            {
                    if (style == item)
                    {
                        _swimmingStyle = swimmingStyle;
                    }
            }
        }


        /// <summary>
        /// Метод добавления фигур.
        /// </summary>
        /// <returns></returns>
        public ExercisesBase AddExercises()
        {
            var swimmng = new Swimming
            {
                Weight = ControlText.CheckNumber(textBox_Weight.Text),
                Time = (int)ControlText.CheckNumber(textBox_Time.Text),
                Style = _swimmingStyle,
            };

            return swimmng;
        }
    }
}
