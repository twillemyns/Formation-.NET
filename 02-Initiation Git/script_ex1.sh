git init
touch fichier1.txt
git add .
commit -m "Premier commit"
touch fichier2.txt
git add .
commit -m "Deuxième commit"
echo "coucou" > fichier2.txt
git log