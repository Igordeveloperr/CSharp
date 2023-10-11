using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _32_Резня_капусты.settings
{
    internal class SettingManager
    {
        // DTO
        private SettingsObj settings = new SettingsObj();
        // сохранение настроек в файл
        public void SaveSettings(List<Color> colors, int speed, int probability)
        {
            settings.Color0 = colors[0];
            settings.Color1 = colors[1];
            settings.Color2 = colors[2];
            settings.Color3 = colors[3];
            settings.Color4 = colors[4];
            settings.Color5 = colors[5];
            settings.Color6 = colors[6];
            settings.Color7 = colors[7];
            settings.Color8 = colors[8];
            settings.Color9 = colors[9];
            settings.Speed = speed;
            settings.Probability = probability;
            // сериализация в json
            string json = JsonConvert.SerializeObject(settings);

            // запендюриваем настройки в файл
            SaveFileDialog svDialog = new SaveFileDialog();
            svDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (svDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string path = svDialog.FileName;

            using (StreamWriter stream = new StreamWriter(path, false))
            {
                stream.WriteLine(json);
            }
        }

        public SettingsObj OpenSettings()
        {
            SettingsObj settings = null;
            OpenFileDialog opDialog = new OpenFileDialog();
            if (opDialog.ShowDialog() == DialogResult.Cancel)
                return settings;

            // получаем выбранный файл
            string path = opDialog.FileName;
            string json = string.Empty;
            using (StreamReader stream = new StreamReader(path))
            {
                json = stream.ReadToEnd();
            }

            try
            {
                settings = JsonConvert.DeserializeObject<SettingsObj>(json);
            } catch(JsonReaderException ex)
            {
                MessageBox.Show("Файл поврежден!");
            }

            return settings;
        }
    }
}
