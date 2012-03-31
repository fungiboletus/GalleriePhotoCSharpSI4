using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AccesDonnees
{
    interface I_AccesDonnees
    {
        // Gestion des utilisateurs
        int ajouterUtilisateur(String nom, String hashMotDePasse);
        void supprimerUtilisateur(int utilisateur);
        List<Tuple<int, String>> recupererUtilisateurs();
        int connexionUtilisateur(String nom, String hashMotDePasse);

        // Gestion des albums
        int ajouterAlbum(int utilisateur, String nomAlbum);
        void supprimerAlbum(int album);
        List<Tuple<int, String>> recupererAlbums(int utilisateur);

        // Gestion des photos
        int ajouterPhoto(int album, String nomPhoto, Stream photo);
        void supprimerPhoto(int photo);
        List<Tuple<int, String, Stream>> recuperPhotos(int album);

        // Gestion des autorisations de visualisation
        void ajouterAutorisation(int album, int utilisateur);
        void supprimerAutorisation(int album, int utilisateur);
        List<Tuple<int, String>> recupererUtilisateursAutorises(int album);
    }
}
