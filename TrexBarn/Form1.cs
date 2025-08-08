using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace TrexBarn
{

    public partial class Form1 : Form
    {


        public int StrawAmount = 0;   // İnek samanı
        public int BaitAmount = 0;    // Tavuk yemi
        public int GrassAmount = 0;


        public void UpdateStrawProgressBar()
        {
            progressBarStraw1.Value = Math.Min(progressBarStraw1.Maximum, StrawAmount);
        }

        public void UpdateBaitProgressBar()
        {
            progressBarBait1.Value = Math.Min(progressBarBait1.Maximum, BaitAmount);
        }

        public void UpdateGrassProgressBar()
        {
            progressBarGras1.Value = Math.Min(progressBarGras1.Maximum, GrassAmount);
        }

        int cash = 200;


        int milkProgress = 0;
        int meatProgress = 0;
        int eggProgress = 0;

        int milkCount = 0;
        int meatCount = 0;
        int eggCount = 0;

        bool hasCow = false;
        bool hasChicken = false;
        bool hasSheep = false;

        bool cowDeadMessageShown = false;
        bool chickenDeadMessageShown = false;
        bool sheepDeadMessageShown = false;


        public Form1()
        {
            InitializeComponent();
        }

        List<Animal> animals = new List<Animal>();



        private void milkTimer_Tick(object sender, EventArgs e)
        {
            var cows = animals.Where(a => a.Species == "Cow" && a.IsAlive).ToList();
            if (cows.Count == 0 || StrawAmount <= 0) return;

            foreach (var cow in cows)
            {
                if (!cow.CanProduce()) continue;

                if (DateTime.Now >= cow.NextProductionTime && StrawAmount > 0)
                {
                    cow.Produced++;
                    milkCount++;
                    StrawAmount--;
                    cow.NextProductionTime = DateTime.Now.AddSeconds(cow.GetProductionInterval());
                }
            }

            UpdateStrawProgressBar();

            if (progressBarMilk.Value < progressBarMilk.Maximum)
                progressBarMilk.Value += 1;
            else
                progressBarMilk.Value = 0;

            lblMilkCount.Text = milkCount.ToString();
            UpdateDataGrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBarStraw1.Maximum = 100;
            progressBarStraw1.Value = 0;

            progressBarGras1.Maximum = 100;
            progressBarGras1.Value = 0;

            progressBarBait1.Maximum = 100;
            progressBarBait1.Value = 0;

            cmbSpecies.Items.Add("Cow");
            cmbSpecies.Items.Add("Chicken");
            cmbSpecies.Items.Add("Sheep");

            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");

            // Timer ayarları
            milkTimer.Interval = 1000;
            milkTimer.Tick += milkTimer_Tick;

            eggTimer.Interval = 1000;
            eggTimer.Tick += eggTimer_Tick;

            meatTimer.Interval = 1000;
            meatTimer.Tick += meatTimer_Tick;

            lifeTimer.Interval = 1000;
            lifeTimer.Tick += lifeTimer_Tick;
            lifeTimer.Start();

            cash = 2000;
            lblCash.Text = cash.ToString();
        }



        private void meatTimer_Tick(object sender, EventArgs e)
        {
            var sheeps = animals.Where(a => a.Species == "Sheep" && a.IsAlive).ToList();
            if (sheeps.Count == 0 || GrassAmount < sheeps.Count) return;

            foreach (var sheep in sheeps)
            {
                if (!sheep.CanProduce()) continue;

                if (DateTime.Now >= sheep.NextProductionTime)
                {
                    sheep.Produced++;
                    meatCount++;
                    sheep.NextProductionTime = DateTime.Now.AddSeconds(sheep.GetProductionInterval());
                }
            }

            GrassAmount -= sheeps.Count;
            UpdateGrassProgressBar();

            if (progressBarMeat.Value < progressBarMeat.Maximum)
                progressBarMeat.Value += 1;
            else
                progressBarMeat.Value = 0;

            lblMeatCount.Text = meatCount.ToString();
            UpdateDataGrid();
        }

        private void eggTimer_Tick(object sender, EventArgs e)
        {
            var chickens = animals.Where(a => a.Species == "Chicken" && a.IsAlive).ToList();
            if (chickens.Count == 0 || BaitAmount <= 0) return;

            foreach (var chicken in chickens)
            {
                if (!chicken.CanProduce()) continue;

                if (DateTime.Now >= chicken.NextProductionTime && BaitAmount > 0)
                {
                    chicken.Produced++;
                    eggCount++;
                    BaitAmount--;
                    chicken.NextProductionTime = DateTime.Now.AddSeconds(chicken.GetProductionInterval());
                }
            }

            UpdateBaitProgressBar();

            if (progressBarEgg.Value < progressBarEgg.Maximum)
                progressBarEgg.Value += 1;
            else
                progressBarEgg.Value = 0;

            lblEggCount.Text = eggCount.ToString();
            UpdateDataGrid();
        }
        private void UpdateDataGrid()
        {
            int scrollPos = 0;

            if (dataGridView1.FirstDisplayedScrollingRowIndex >= 0)
                scrollPos = dataGridView1.FirstDisplayedScrollingRowIndex;

            var data = animals.Select(a => new
            {
                a.Species,
                a.Gender,
                a.Age,
                Alive = a.IsAlive,
                Produced = a.Produced,
                Sold = a.Sold
            }).ToList();

            dataGridView1.DataSource = data;

            // Scroll pozisyonunu geri yükle
            if (dataGridView1.RowCount > scrollPos)
                dataGridView1.FirstDisplayedScrollingRowIndex = scrollPos;
        }


        private void BtnAdd_Click(object sender, EventArgs e)
        {

            if (cmbSpecies.SelectedItem == null || cmbGender.SelectedItem == null || string.IsNullOrWhiteSpace(txtAge.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!");
                return;
            }

            if (!int.TryParse(txtAge.Text, out int age) || age < 0)
            {
                MessageBox.Show("Lütfen geçerli bir yaş girin!");
                return;
            }
            if (age > 8)
            {
                MessageBox.Show("En fazla 8 yaşında olabilir!");
                return;
            }

            string species = cmbSpecies.SelectedItem.ToString();
            string gender = cmbGender.SelectedItem.ToString();

            int price = 0;

            switch (species)
            {
                case "Cow":
                    if (age == 0) price = 90;
                    else if (age == 1) price = 150;
                    else if (age == 2) price = 140;
                    else if (age == 3) price = 120;
                    else if (age == 4) price = 110;
                    else price = 100;
                    break;

                case "Sheep":
                    if (age == 0) price = 60;
                    else if (age == 1) price = 80;
                    else if (age == 2) price = 75;
                    else if (age == 3) price = 70;
                    else if (age == 4) price = 65;
                    else price = 50;
                    break;

                case "Chicken":
                    if (age == 0) price = 25;
                    else if (age == 1) price = 45;
                    else if (age == 2) price = 40;
                    else if (age == 3) price = 35;
                    else if (age == 4) price = 30;
                    else price = 20;
                    break;
                default:
                    MessageBox.Show("Geçersiz hayvan türü!");
                    return;
            }

            if (cash < price)
            {
                MessageBox.Show("Yeterli paranız yok!");
                return;
            }

            cash -= price;
            lblCash.Text = cash.ToString();

            Animal newAnimal;

            switch (species)
            {
                case "Cow":
                    newAnimal = new Cow() { Gender = gender, Age = age, Species = species };
                    milkTimer.Start();
                    cowDeadMessageShown = false;
                    hasCow = true;
                    break;
                case "Chicken":
                    newAnimal = new Chicken() { Gender = gender, Age = age, Species = species };
                    eggTimer.Start();
                    chickenDeadMessageShown = false;
                    hasChicken = true;
                    break;
                case "Sheep":
                    newAnimal = new Sheeps() { Gender = gender, Age = age, Species = species };
                    meatTimer.Start();
                    sheepDeadMessageShown = false;
                    hasSheep = true;
                    break;
                default:
                    return;
            }

            animals.Add(newAnimal);
            UpdateDataGrid();

            cmbSpecies.SelectedIndex = -1;
            cmbGender.SelectedIndex = -1;
            txtAge.Clear();
        }

        private void lifeTimer_Tick(object sender, EventArgs e)
        {
            foreach (var animal in animals)
            {
                if (!animal.IsAlive)
                    continue;

                animal.UpdateAge();

                switch (animal.Species)
                {
                    case "Cow":
                        if (StrawAmount > 0)
                            StrawAmount--;
                        break;
                    case "Sheep":
                        if (GrassAmount > 0)
                            GrassAmount--;
                        break;
                    case "Chicken":
                        if (BaitAmount > 0)
                            BaitAmount--;
                        break;
                }

                if (animal.IsAlive)
                    animal.UpdateAge(); // ✅ Sadece yaşayanların yaşı artar
            }



            // Ölüm sonrası uyarı mesajları (bunlar kalacak 👇)
            if (hasCow && !cowDeadMessageShown && animals.Any(a => a.Species == "Cow") && animals.Where(a => a.Species == "Cow").All(a => !a.IsAlive))
            {
                cowDeadMessageShown = true;
                MessageBox.Show("Tüm inekler öldü!");
                hasCow = false;
                milkTimer.Stop();
                milkProgress = 0;
                progressBarMilk.Value = 0;
            }

            if (hasChicken && !chickenDeadMessageShown && animals.Any(a => a.Species == "Chicken") && animals.Where(a => a.Species == "Chicken").All(a => !a.IsAlive))
            {
                chickenDeadMessageShown = true;
                MessageBox.Show("Tüm tavuklar öldü!");
                hasChicken = false;
                eggTimer.Stop();
                eggProgress = 0;
                progressBarEgg.Value = 0;
            }

            if (hasSheep && !sheepDeadMessageShown && animals.Any(a => a.Species == "Sheep") && animals.Where(a => a.Species == "Sheep").All(a => !a.IsAlive))
            {
                sheepDeadMessageShown = true;
                MessageBox.Show("Tüm koyunlar öldü!");
                hasSheep = false;
                meatTimer.Stop();
                meatProgress = 0;
                progressBarMeat.Value = 0;
            }

            UpdateDataGrid();
        }

        private void btnSellMilk_Click(object sender, EventArgs e)
        {
            int adet = 1; // varsayılan olarak 1 adet satılacak

            // Kullanıcı textbox'a sayı girdiyse onu al
            if (!string.IsNullOrWhiteSpace(txtSellMilk.Text))
            {
                if (!int.TryParse(txtSellMilk.Text, out adet) || adet <= 0)
                {
                    MessageBox.Show("Geçerli bir sayı girin!");
                    return;
                }
            }

            var cows = animals.Where(a => a.Species == "Cow" && a.Produced > 0).ToList();
            int toplamUrun = cows.Sum(c => c.Produced);

            if (toplamUrun < adet)
            {
                MessageBox.Show("Elinizde o kadar süt yok!");
                return;
            }

            int kalan = adet;

            foreach (var cow in cows)
            {
                if (kalan == 0) break;

                int satilacak = Math.Min(cow.Produced, kalan);
                cow.Produced -= satilacak;
                cow.Sold += satilacak;
                milkCount -= satilacak;
                cash += satilacak * 160;
                kalan -= satilacak;
            }

            lblMilkCount.Text = milkCount.ToString();
            lblCash.Text = cash.ToString();
            UpdateDataGrid();
            txtSellMilk.Clear();
        }

        private void btnSellEgg_Click(object sender, EventArgs e)
        {
            int adet = 1;

            if (!string.IsNullOrWhiteSpace(txtSellEgg.Text))
            {
                if (!int.TryParse(txtSellEgg.Text, out adet) || adet <= 0)
                {
                    MessageBox.Show("Geçerli bir sayı girin!");
                    return;
                }
            }

            var chickens = animals.Where(a => a.Species == "Chicken" && a.Produced > 0).ToList();
            int toplamUrun = chickens.Sum(c => c.Produced);

            if (toplamUrun < adet)
            {
                MessageBox.Show("Elinizde o kadar yumurta yok!");
                return;
            }

            int kalan = adet;

            foreach (var chicken in chickens)
            {
                if (kalan == 0) break;

                int satilacak = Math.Min(chicken.Produced, kalan);
                chicken.Produced -= satilacak;
                chicken.Sold += satilacak;
                eggCount -= satilacak;
                cash += satilacak * 130;
                kalan -= satilacak;
            }

            lblEggCount.Text = eggCount.ToString();
            lblCash.Text = cash.ToString();
            UpdateDataGrid();
            txtSellEgg.Clear();
        }

        private void btnSellMeat_Click(object sender, EventArgs e)
        {
            int adet = 1;

            if (!string.IsNullOrWhiteSpace(txtSellMeat.Text))
            {
                if (!int.TryParse(txtSellMeat.Text, out adet) || adet <= 0)
                {
                    MessageBox.Show("Geçerli bir sayı girin!");
                    return;
                }
            }

            var sheeps = animals.Where(a => a.Species == "Sheep" && a.Produced > 0).ToList();
            int toplamUrun = sheeps.Sum(c => c.Produced);

            if (toplamUrun < adet)
            {
                MessageBox.Show("Elinizde o kadar et yok!");
                return;
            }

            int kalan = adet;

            foreach (var sheep in sheeps)
            {
                if (kalan == 0) break;

                int satilacak = Math.Min(sheep.Produced, kalan);
                sheep.Produced -= satilacak;
                sheep.Sold += satilacak;
                meatCount -= satilacak;
                cash += satilacak * 180;
                kalan -= satilacak;
            }

            lblMeatCount.Text = meatCount.ToString();
            lblCash.Text = cash.ToString();
            UpdateDataGrid();
            txtSellMeat.Clear();
        }

        private void btnBuyStraw_Click(object sender, EventArgs e)

        {
            int maxAmount = 300;
            int unitPrice = 3;

            int needed = maxAmount - StrawAmount;
            int totalCost = needed * unitPrice;

            if (needed == 0)
            {
                MessageBox.Show("Saman deposu zaten dolu!");
                return;
            }

            if (cash < totalCost)
            {
                MessageBox.Show("Yeterli paranız yok!");
                return;
            }

            // Güncelleme kısmı burası:
            StrawAmount += needed;
            cash -= totalCost;

            lblCash.Text = cash.ToString();
            UpdateStrawProgressBar();
        }

        private void btnBuyGrass_Click(object sender, EventArgs e)
        {
            int maxAmount = 300;
            int unitPrice = 2;

            int needed = maxAmount - GrassAmount;
            int totalCost = needed * unitPrice;

            if (needed == 0)
            {
                MessageBox.Show("Ot deposu zaten dolu!");
                return;
            }

            if (cash < totalCost)
            {
                MessageBox.Show("Yeterli paranız yok!");
                return;
            }

            GrassAmount += needed;
            cash -= totalCost;

            lblCash.Text = cash.ToString();
            UpdateGrassProgressBar();
        }

        private void btnBuyBait_Click(object sender, EventArgs e)
        {
            int maxAmount = 300;
            int unitPrice = 1;

            int needed = maxAmount - BaitAmount;
            int totalCost = needed * unitPrice;

            if (needed == 0)
            {
                MessageBox.Show("Yem deposu zaten dolu!");
                return;
            }

            if (cash < totalCost)
            {
                MessageBox.Show("Yeterli paranız yok!");
                return;
            }

            BaitAmount += needed;
            cash -= totalCost;

            lblCash.Text = cash.ToString();
            UpdateBaitProgressBar();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void progressBarStraw1_Click(object sender, EventArgs e)
        {

        }
    }
}
