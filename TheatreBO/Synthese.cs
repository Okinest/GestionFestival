using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreBO
{
    public class Synthese
    {
        private Representation representation;
        private Pieces piece;
        private int nbRepresentation;
        private int nbSpectateur;
        private double nbSpectateurMoyen;
        private double chiffreAffaire;
        private double chiffreAffaireMoyen;

        public Synthese(Pieces piece, int nbRepresentation, int nbSpectateur, double nbSpectateurMoyen, double chiffreAffaire, double chiffreAffaireMoyen)
        {
            this.piece = piece;
            this.nbRepresentation = nbRepresentation;
            this.nbSpectateur = nbSpectateur;
            this.nbSpectateurMoyen = nbSpectateurMoyen;
            this.chiffreAffaire = chiffreAffaire;
            this.chiffreAffaireMoyen = chiffreAffaireMoyen;
        }

        public Pieces Piece { get { return piece; } set { piece = value; } }
        public int NbRepresentation { get { return nbRepresentation; } set { nbRepresentation = value; } }
        public int NbSpectateur { get { return nbSpectateur; } set { nbSpectateur = value; } }
        public double NbSpectateurMoyen { get { return nbSpectateurMoyen; } set { nbSpectateurMoyen = value; } }
        public double ChiffreAffaire { get { return chiffreAffaire; } set { chiffreAffaire = value; } }
        public double ChiffreAffaireMoyen { get { return chiffreAffaireMoyen; } set { chiffreAffaireMoyen = value; } }

        public string Piece_name { get { return piece.Play_name; } }
        public DateTime Rep_date { get { return representation.Rep_date; } }
    }
}
