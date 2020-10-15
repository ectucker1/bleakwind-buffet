﻿using RoundRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

/*
 * Author: Ethan Tucker
 * Class name: CashPaymentViewModel
 * Purpose: Provides a ViewModel to handle calculations needed for cash payments
 */
namespace PointOfSale.Controls.Payment
{
    public class CashPaymentViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler called when a property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private double totalSale = 0.0;
        /// <summary>
        /// The total price of the order being paid for
        /// </summary>
        public double TotalSale
        {
            get => totalSale;
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountDue)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeDue)));
            }
        }

        /// <summary>
        /// The amount of the total price which the customer has not yet paid for
        /// </summary>
        public double AmountDue => Math.Clamp(TotalSale - AmountPaid, 0.0, Double.MaxValue);

        /// <summary>
        /// The amount of cash which the customer has paid
        /// </summary>
        public double AmountPaid
        {
            get
            {
                double total = 0.0;
                total += 0.01 * PenniesGiven;
                total += 0.05 * NickelsGiven;
                total += 0.10 * DimesGiven;
                total += 0.25 * QuartersGiven;
                total += 0.50 * HalfDollarsGiven;
                total += 1.00 * DollarsGiven;
                total += 1.00 * OnesGiven;
                total += 2.00 * TwosGiven;
                total += 5.00 * FivesGiven;
                total += 10.00 * TensGiven;
                total += 20.00 * TwentiesGiven;
                total += 50.00 * FiftiesGiven;
                total += 100.00 * HundredsGiven;
                return total;
            }
        }

        /// <summary>
        /// The amount of change which is owed to the customer
        /// </summary>
        public double ChangeDue => Math.Clamp(AmountPaid - TotalSale, 0.0, Double.MaxValue);

        private int penniesGiven = 0;
        /// <summary>
        /// The number of pennies paid by the customer
        /// </summary>
        public int PenniesGiven
        {
            get => penniesGiven;
            set
            {
                penniesGiven = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PenniesGiven)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountPaid)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountDue)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeDue)));
            }
        }

        private int nickelsGiven = 0;
        /// <summary>
        /// The number of nickels paid by the customer
        /// </summary>
        public int NickelsGiven
        {
            get => nickelsGiven;
            set
            {
                nickelsGiven = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PenniesGiven)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountPaid)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountDue)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeDue)));
            }
        }

        private int dimesGiven = 0;
        /// <summary>
        /// The number of dimes paid by the customer
        /// </summary>
        public int DimesGiven
        {
            get => dimesGiven;
            set
            {
                dimesGiven = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PenniesGiven)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountPaid)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountDue)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeDue)));
            }
        }

        private int quartersGiven = 0;
        /// <summary>
        /// The number of quarters paid by the customer
        /// </summary>
        public int QuartersGiven
        {
            get => quartersGiven;
            set
            {
                quartersGiven = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PenniesGiven)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountPaid)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountDue)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeDue)));
            }
        }

        private int halfDollarsGiven = 0;
        /// <summary>
        /// The number of half dollars paid by the customer
        /// </summary>
        public int HalfDollarsGiven
        {
            get => halfDollarsGiven;
            set
            {
                halfDollarsGiven = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PenniesGiven)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountPaid)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountDue)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeDue)));
            }
        }

        private int dollarsGiven = 0;
        /// <summary>
        /// The number of dollar coins paid by the customer
        /// </summary>
        public int DollarsGiven
        {
            get => dollarsGiven;
            set
            {
                dollarsGiven = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PenniesGiven)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountPaid)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountDue)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeDue)));
            }
        }

        private int onesGiven = 0;
        /// <summary>
        /// The number of ones paid by the customer
        /// </summary>
        public int OnesGiven
        {
            get => onesGiven;
            set
            {
                onesGiven = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PenniesGiven)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountPaid)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountDue)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeDue)));
            }
        }

        private int twosGiven = 0;
        /// <summary>
        /// The number of twos paid by the customer
        /// </summary>
        public int TwosGiven
        {
            get => twosGiven;
            set
            {
                twosGiven = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PenniesGiven)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountPaid)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountDue)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeDue)));
            }
        }

        private int fivesGiven = 0;
        /// <summary>
        /// The number of fives paid by the customer
        /// </summary>
        public int FivesGiven
        {
            get => fivesGiven;
            set
            {
                fivesGiven = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PenniesGiven)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountPaid)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountDue)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeDue)));
            }
        }

        private int tensGiven = 0;
        /// <summary>
        /// The number of tens paid by the customer
        /// </summary>
        public int TensGiven
        {
            get => tensGiven;
            set
            {
                tensGiven = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PenniesGiven)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountPaid)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountDue)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeDue)));
            }
        }

        private int twentiesGiven = 0;
        /// <summary>
        /// The number of twenties paid by the customer
        /// </summary>
        public int TwentiesGiven
        {
            get => twentiesGiven;
            set
            {
                twentiesGiven = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PenniesGiven)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountPaid)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountDue)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeDue)));
            }
        }

        private int fiftiesGiven = 0;
        /// <summary>
        /// The number of fifties paid by the customer
        /// </summary>
        public int FiftiesGiven
        {
            get => fiftiesGiven;
            set
            {
                fiftiesGiven = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PenniesGiven)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountPaid)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountDue)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeDue)));
            }
        }

        private int hundredsGiven = 0;
        /// <summary>
        /// The number of hundreds paid by the customer
        /// </summary>
        public int HundredsGiven
        {
            get => hundredsGiven;
            set
            {
                hundredsGiven = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PenniesGiven)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountPaid)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AmountDue)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChangeDue)));
            }
        }

        /// <summary>
        /// The number of pennies that should be given as change
        /// </summary>
        public int PenniesChange { get; private set; }

        /// <summary>
        /// The number of nickels that should be given as change
        /// </summary>
        public int NickelsChange { get; private set; }

        /// <summary>
        /// The number of dimes that should be given as change
        /// </summary>
        public int DimesChange { get; private set; }

        /// <summary>
        /// The number of quarters that should be given as change
        /// </summary>
        public int QuartersChange { get; private set; }

        /// <summary>
        /// The number of half dollars that should be given as change
        /// </summary>
        public int HalfDollarsChange { get; private set; }

        /// <summary>
        /// The number of dollar coins that should be given as change
        /// </summary>
        public int DollarsChange { get; private set; }

        /// <summary>
        /// The number of ones that should be given as change
        /// </summary>
        public int OnesChange { get; private set; }

        /// <summary>
        /// The number of twos that should be given as change
        /// </summary>
        public int TwosChange { get; private set; }

        /// <summary>
        /// The number of fives that should be given as change
        /// </summary>
        public int FivesChange { get; private set; }

        /// <summary>
        /// The number of tens that should be given as change
        /// </summary>
        public int TensChange { get; private set; }

        /// <summary>
        /// The number of twenties that should be given as change
        /// </summary>
        public int TwentiesChange { get; private set; }

        /// <summary>
        /// The number of fifties that should be given as change
        /// </summary>
        public int FiftiesChange { get; private set; }

        /// <summary>
        /// The number of hundreds that should be given as change
        /// </summary>
        public int HundredsChange { get; private set; }

        /// <summary>
        /// Creates a new CashPaymentViewModel
        /// </summary>
        public CashPaymentViewModel()
        {
            PropertyChanged += OnOwnPropertyChanged;
        }

        /// <summary>
        /// Recalculates the amount of change that should be given in each currency,
        /// based on what's in the cash drawer.
        /// </summary>
        public void RecalculateChange()
        {
            double left = ChangeDue;

            PenniesChange = 0;
            NickelsChange = 0;
            DimesChange = 0;
            QuartersChange = 0;
            HalfDollarsChange = 0;
            DollarsChange = 0;
            OnesChange = 0;
            TwosChange = 0;
            FivesChange = 0;
            TensChange = 0;
            TwentiesChange = 0;
            FiftiesChange = 0;
            HundredsChange = 0;

            while (left >= 100.00 && CashDrawer.Hundreds > HundredsChange)
            {
                left -= 100.00;
                HundredsChange++;
            }

            while (left >= 50.00 && CashDrawer.Fifties > FiftiesChange)
            {
                left -= 50.00;
                FiftiesChange++;
            }

            while (left >= 20.00 && CashDrawer.Twenties > TwentiesChange)
            {
                left -= 20.00;
                TwentiesChange++;
            }

            while (left >= 10.00 && CashDrawer.Tens > TensChange)
            {
                left -= 10.00;
                TensChange++;
            }

            while (left >= 5.00 && CashDrawer.Fives > FivesChange)
            {
                left -= 5.00;
                FivesChange++;
            }

            while (left >= 2.00 && CashDrawer.Twos > TwosChange)
            {
                left -= 2.00;
                TwosChange++;
            }

            while (left >= 1.00 && CashDrawer.Ones > OnesChange)
            {
                left -= 1.00;
                OnesChange++;
            }

            while (left >= 1.00 && CashDrawer.Dollars > DollarsChange)
            {
                left -= 1.00;
                DollarsChange++;
            }

            while (left >= 0.50 && CashDrawer.HalfDollars > HalfDollarsChange)
            {
                left -= 0.50;
                HalfDollarsChange++;
            }

            while (left >= 0.25 && CashDrawer.Quarters > QuartersChange)
            {
                left -= 0.25;
                QuartersChange++;
            }

            while (left >= 0.10 && CashDrawer.Dimes > DimesChange)
            {
                left -= 0.10;
                DimesChange++;
            }

            while (left >= 0.05 && CashDrawer.Nickels > NickelsChange)
            {
                left -= 0.05;
                NickelsChange++;
            }

            while (left >= 0.01 && CashDrawer.Pennies > PenniesChange)
            {
                left -= 0.01;
                PenniesChange++;
            }

            if (left > 0.0)
            {
                // TODO: Handle case of not enough change
            }

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PenniesChange)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NickelsChange)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DimesChange)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(QuartersChange)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(HalfDollarsChange)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DollarsChange)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(OnesChange)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TwosChange)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FivesChange)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TensChange)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TwentiesChange)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FiftiesChange)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(HundredsChange)));
        }

        /// <summary>
        /// Event handler called when a property changes
        /// </summary>
        /// <param name="sender">This object</param>
        /// <param name="e">PropertyChangedEvent arguements</param>
        private void OnOwnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            // When the amount of change due changes, recalculate how to given that change
            if (e.PropertyName == "ChangeDue")
            {
                RecalculateChange();
            }
        }
    }
}
