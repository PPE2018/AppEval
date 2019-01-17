﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEval
{
    public class Offre
    {
        private int IdOffre;
        private string libelle;
        private string description;
        private string lieu;
        private string typpeContrat;
        private double salaire;
        private DateTime dateLimite;
        private string video;
        private bool supprimer;
        private DateTime dateLimiteOffre;

        public Offre(int unIdOffres, string unLibelle, string unLieu)
        {
            this.IdOffre = unIdOffres;
            this.libelle = unLibelle;
            this.lieu = unLieu;
        }
        public int GetIdOffre()
        {
            return this.IdOffre;
        }

        public string GetLibelle()
        {
            return this.libelle;
        }

        public string GetLieu()
        {
            return this.lieu;
        }
        public Offre(int unIdOffre, string unLibelle, string uneDescription, string unLieu, string unTypeContrat, double unSalaire, 
            DateTime uneDateLimite, string uneVideo,DateTime uneDateLimiteOffre)
        {
            this.IdOffre = unIdOffre;
            this.libelle = unLibelle;
            this.description = uneDescription;
            this.lieu = unLieu;
            this.typpeContrat = unTypeContrat;
            this.salaire = unSalaire;
            this.dateLimite = uneDateLimite;
            this.video = uneVideo;
            this.supprimer = false;
            this.dateLimiteOffre = uneDateLimiteOffre;
        }



    }
}
