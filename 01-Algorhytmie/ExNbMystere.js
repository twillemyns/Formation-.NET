let nb_mystere = Math.floor(Math.random() * 100);
let nb_essais_total = 10
let nb_essais = nb_essais_total;
let nb_joueur = 0;

do {
    alert("Vous avez " + nb_essais + "pour deviner le nombre mystère.")
    let nb_joueur = Number(prompt("Donnez un nombre entre 1 et 100: "));
    nb_essais--;

    if (nb_joueur > nb_mystere) {
        alert("Plus petit !");
    } else if (nb_joueur < nb_mystere) {
        alert("Plus grand !");
    } else if (nb_joueur == nb_mystere) {
        alert("Gagné !!! Vous avez trouvé le nombre en " + (nb_essais_total - nb_essais) + " essais !");
    }

    if (nb_essais == 0) {
        alert("Perdu ! Le nombre mystère était : " + nb_mystere)
    }
} while (nb_essais > 0 || nb_joueur != nb_mystere);