# Lyric-Admin-Form

# Présentation
Ce projet est une application de simulation de pop-up d'administration développée sous Visual Studio en VB.NET. L'application affiche une fenêtre de pop-up qui se ferme une fois la validation effectuée. Après 5 minutes, elle se rouvre automatiquement avec le mot de passe qui a été saisi.

# Fonctionnalités
L'application est constituée de deux fenêtres principales :

Fenêtre de pop-up d'administration : elle permet à l'utilisateur de saisir un mot de passe et de valider ou d'annuler l'opération. Si le mot de passe est correct, la fenêtre se ferme et l'application continue à s'exécuter. Sinon, un message d'erreur est affiché et l'utilisateur est invité à réessayer. Cette fenêtre est implémentée en utilisant la classe Form.

Fenêtre principale de l'application : elle est affichée après la validation du mot de passe. Elle permet à l'utilisateur de configurer les paramètres de l'application, comme la durée avant que le pop-up d'administration ne se rouvre automatiquement. Elle affiche également l'heure à laquelle le pop-up sera de nouveau affiché. Cette fenêtre est implémentée en utilisant la classe MainWindow.

L'application utilise des composants d'interface utilisateur standard tels que des boutons, des zones de texte et des listes déroulantes pour permettre à l'utilisateur de configurer les paramètres de l'application.

# Implémentation
L'application est écrite en VB.NET, un langage de programmation orienté objet développé par Microsoft. Elle utilise les composants de la plateforme .NET Framework pour l'interface utilisateur, le traitement des données et la gestion des événements.

La logique de l'application est gérée par des classes de modèle, qui encapsulent les données et les comportements de l'application. Les classes de modèle sont appelées à partir des événements déclenchés par les composants d'interface utilisateur.

La fenêtre de pop-up d'administration utilise la classe Form pour créer une fenêtre modale qui bloque l'exécution de l'application jusqu'à ce que l'utilisateur ait pris une décision. Le mot de passe est stocké dans une variable sécurisée à l'aide de la classe SecureString, qui protège les données en mémoire contre les attaques malveillantes.

La fenêtre principale de l'application utilise la classe MainWindow, qui hérite de la classe Window. Elle permet à l'utilisateur de configurer les paramètres de l'application en utilisant des composants d'interface utilisateur standard tels que des boutons, des zones de texte et des listes déroulantes.

# Conclusion
Cette application de simulation de pop-up d'administration montre comment utiliser Visual Studio et VB.NET pour créer une application Windows Desktop simple mais utile. Elle utilise des composants standard pour permettre à l'utilisateur de configurer les paramètres de l'application et est sécurisée en utilisant des variables sécurisées pour stocker les mots de passe.