-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Sam 29 Mai 2021 à 12:06
-- Version du serveur :  5.6.17
-- Version de PHP :  5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données :  `jenvrain_boutique`
--

DELIMITER $$
--
-- Procédures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `PSDeleteCommandeById`(IN `idCom` INT)
    NO SQL
delete from commande where idCommande = idCom$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSDeleteEmployes`(IN `idClient` INT)
    NO SQL
DELETE from employe where idCli = idClient$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSDeleteInternauteById`(IN `idClient` INT)
    NO SQL
DELETE from internaute where idCli = idClient$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSDeleteProduitByCommande`()
    NO SQL
delete from produit where idCommande = idCom$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSGetDetailCommande`(IN `idCom` INT)
    NO SQL
SELECT produit.idProduit, produit.LibelleProduit, produit.PrixHTProduit, lignedecommande.QuantiteCom, (produit.PrixHTProduit*lignedecommande.QuantiteCom) from commande, lignedecommande, produit where produit.idProduit = lignedecommande.idProduit and lignedecommande.idCommande = commande.idCommande and commande.idCommande = idCom$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSGetLaCommandeById`(IN `idCom` INT)
    NO SQL
select * from commande where idcommande = idCom$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSGetLesCategories`()
    NO SQL
select * from categorie$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSGetLesClients`()
    NO SQL
select * from client$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSGetLesCommandes`()
    NO SQL
SELECT * FROM commande$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSGetLesEmployes`()
    NO SQL
select * from employe$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSGetLesInternautes`()
    NO SQL
SELECT * from internaute$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSGetLesProduits`()
    NO SQL
SELECT * FROM produit$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSGetLesProduitsByCategorie`(IN `idCat` INT)
    NO SQL
select distinct(libelleproduit), idproduit from produit, categorie where produit.idCat = categorie.idCategorie and idcategorie = idCat$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSGetLesProduitsByCommande`(IN `idCom` INT)
    NO SQL
select distinct(libelleproduit), idproduit from produit, commande where produit.idProduit = lignedecommande.idProduit and idCommande = idCom$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSGetQteProduitCommande`(IN `idCom` INT, IN `idProd` INT)
    NO SQL
select count(*) from lignedecommande where idCommande = idCom and idProduit = idProd$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSInsertClientEmploye`(IN `idCli` INT, IN `nomCli` VARCHAR(200), IN `prenomCli` VARCHAR(200), IN `AdCli` VARCHAR(200), IN `CpCli` INT, IN `VilleCli` VARCHAR(200))
    NO SQL
insert into client values( idCli, nomCli, prenomCli, AdCli, CpCli, VilleCli, 1, 0)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSInsertClientInternaute`(IN `idCli` INT, IN `nomCli` VARCHAR(200), IN `prenomCli` VARCHAR(200), IN `AdCli` VARCHAR(200), IN `CpCli` INT, IN `VilleCli` VARCHAR(200))
    NO SQL
insert into client values( idCli, nomCli, prenomCli, AdCli, CpCli, VilleCli, 0, 1)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSInsertEmployes`(IN `idClient` INT, IN `DateEmbauche` VARCHAR(255), IN `Poste` VARCHAR(255), IN `Salaire` INT)
    NO SQL
insert into employe values(idClient,DateEmbauche,Poste,Salaire)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSInsertInternaute`(IN `idCli` INT, IN `login` VARCHAR(255), IN `mdp` VARCHAR(255), IN `dateInscription` VARCHAR(255))
    NO SQL
insert into internaute values(idCli, login, mdp, dateInscription, 0 , 0 )$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSInsertProduitByCommande`(IN `idCom` INT(255), IN `idProd` INT(255), IN `qte` INT(255))
    NO SQL
insert into lignedecommande values( idCom, idProd, qte)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSUpdateEmployes`(IN `idClient` INT, IN `NewDateEmbauche` VARCHAR(255), IN `NewPoste` VARCHAR(255), IN `NewSalaire` INT)
    NO SQL
update employe set DateEmbauche = NewDateEmbauche, Poste = NewPoste, Salaire = NewSalaire where idCli = idClient$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSUpdateInternaute`(IN `id` INT, IN `Newlogin` VARCHAR(255), IN `Newmdp` VARCHAR(255), IN `NewDateInscription` VARCHAR(255))
    NO SQL
update Internaute set login = Newlogin, mdp = Newmdp, dateInscription = NewdateInscription, CAInternaute =0, CATotal = 0 where idCli = id$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `categorie`
--

CREATE TABLE IF NOT EXISTS `categorie` (
  `idCategorie` int(11) NOT NULL,
  `LibelleCategorie` varchar(45) DEFAULT NULL,
  `CA` int(11) NOT NULL,
  PRIMARY KEY (`idCategorie`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `categorie`
--

INSERT INTO `categorie` (`idCategorie`, `LibelleCategorie`, `CA`) VALUES
(1, 'Materiel', 2250),
(2, 'Logiciel', 0),
(3, 'Service', 0),
(4, 'Documentation', 0);

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

CREATE TABLE IF NOT EXISTS `client` (
  `idClient` int(11) NOT NULL,
  `NomClient` varchar(100) DEFAULT NULL,
  `PrenomClient` varchar(45) DEFAULT NULL,
  `AdRueClient` varchar(150) DEFAULT NULL,
  `AdCpClient` int(11) DEFAULT NULL,
  `AdVilleClient` varchar(100) DEFAULT NULL,
  `isEmploye` tinyint(1) NOT NULL,
  `isInternaute` tinyint(1) NOT NULL,
  PRIMARY KEY (`idClient`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `client`
--

INSERT INTO `client` (`idClient`, `NomClient`, `PrenomClient`, `AdRueClient`, `AdCpClient`, `AdVilleClient`, `isEmploye`, `isInternaute`) VALUES
(1, 'Dupont', 'Roger', '12 rue du patus', 34500, 'Beziers', 1, 0),
(2, 'Durand', 'Yves', '17 rue des greses', 34500, 'Beziers', 0, 1),
(3, 'Dumas', 'Luc', '7 rue de la grangette', 34410, 'sauvian', 0, 1),
(4, 'Jackson', 'Michael', '35 rue des cimetières', 86542, 'Los angelss', 1, 0);

--
-- Déclencheurs `client`
--
DROP TRIGGER IF EXISTS `VerifClient`;
DELIMITER //
CREATE TRIGGER `VerifClient` BEFORE INSERT ON `client`
 FOR EACH ROW BEGIN
DECLARE employé bool;
DECLARE internaute bool;
DECLARE msg varChar(900);
SET employé = new.isEmploye;
set internaute = new.isInternaute;
if (employé = 0 and internaute = 0)then
set msg = 'Le Client doit être internaute ou employé';
    SIGNAL SQLSTATE '45000' set MESSAGE_TEXT = msg;
elseif (employé = 1 and internaute = 1)then
set msg = 'Le Client ne peut pas être internaute et employé à la fois';
    SIGNAL SQLSTATE '45000' set MESSAGE_TEXT = msg;
    end if;
    END
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `commande`
--

CREATE TABLE IF NOT EXISTS `commande` (
  `idCommande` int(11) NOT NULL,
  `DateCommande` varchar(10) DEFAULT NULL,
  `idCli` int(11) DEFAULT NULL,
  PRIMARY KEY (`idCommande`),
  KEY `FKCli` (`idCli`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `commande`
--

INSERT INTO `commande` (`idCommande`, `DateCommande`, `idCli`) VALUES
(1, '22/01/2018', 1),
(2, '21/01/2018', 1),
(3, '21/01/2018', 2),
(4, '22/01/2018', 2),
(5, '11/02/2020', 3),
(6, '41/11/5555', 3);

--
-- Déclencheurs `commande`
--
DROP TRIGGER IF EXISTS `VerifCommande`;
DELIMITER //
CREATE TRIGGER `VerifCommande` BEFORE INSERT ON `commande`
 FOR EACH ROW BEGIN
DECLARE idCliC iNTEger;
DECLARE NbComCli integer;
DECLARE msg integer ;
Set idCliC = new.idCli;
set NbComCli = (SELECT count(*) from commande where idCli = idCliC);

if (NbComCli != 0) then
set msg = 'Le Client a déjà une commande en cours';
    SIGNAL SQLSTATE '45000' set MESSAGE_TEXT = msg;
    end if;
    END
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `employe`
--

CREATE TABLE IF NOT EXISTS `employe` (
  `idCli` int(11) NOT NULL AUTO_INCREMENT,
  `DateEmbauche` varchar(50) NOT NULL,
  `Poste` varchar(50) NOT NULL,
  `Salaire` int(11) NOT NULL,
  PRIMARY KEY (`idCli`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Contenu de la table `employe`
--

INSERT INTO `employe` (`idCli`, `DateEmbauche`, `Poste`, `Salaire`) VALUES
(1, '21/12/2019', 'Gardien', 1500),
(4, '01/05/2019', 'Vendeur', 1300);

-- --------------------------------------------------------

--
-- Structure de la table `fournisseur`
--

CREATE TABLE IF NOT EXISTS `fournisseur` (
  `idFournisseur` int(11) NOT NULL,
  `NomFournisseur` varchar(100) DEFAULT NULL,
  `VilleFournisseur` varchar(100) DEFAULT NULL,
  `CPFournisseur` int(11) DEFAULT NULL,
  PRIMARY KEY (`idFournisseur`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `fournisseur`
--

INSERT INTO `fournisseur` (`idFournisseur`, `NomFournisseur`, `VilleFournisseur`, `CPFournisseur`) VALUES
(1, 'DELL Computers', 'Montpellier', 34000),
(2, 'IBM', 'Montpellier', 34000),
(3, 'RC Consulting', 'Sérignan', 34500);

-- --------------------------------------------------------

--
-- Structure de la table `internaute`
--

CREATE TABLE IF NOT EXISTS `internaute` (
  `idCli` int(11) NOT NULL AUTO_INCREMENT,
  `Login` varchar(50) NOT NULL,
  `MDP` varchar(50) NOT NULL,
  `DateInscription` varchar(50) NOT NULL,
  `CAInternaute` int(11) NOT NULL,
  `CATotal` int(11) NOT NULL,
  PRIMARY KEY (`idCli`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Contenu de la table `internaute`
--

INSERT INTO `internaute` (`idCli`, `Login`, `MDP`, `DateInscription`, `CAInternaute`, `CATotal`) VALUES
(2, 'YD', 'Yves34', '02/12/2020', 0, 0),
(3, 'LabZ', 'jesuisMDP', '02/12/2020', 0, 0);

-- --------------------------------------------------------

--
-- Structure de la table `lignedecommande`
--

CREATE TABLE IF NOT EXISTS `lignedecommande` (
  `idCommande` int(11) NOT NULL,
  `idProduit` int(11) NOT NULL,
  `QuantiteCom` int(11) NOT NULL,
  PRIMARY KEY (`idCommande`,`idProduit`),
  KEY `FKCom` (`idCommande`),
  KEY `FKProd` (`idProduit`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `lignedecommande`
--

INSERT INTO `lignedecommande` (`idCommande`, `idProduit`, `QuantiteCom`) VALUES
(1, 1, 1),
(1, 2, 2),
(1, 3, 1),
(1, 4, 3),
(2, 2, 1),
(2, 3, 1),
(2, 4, 2),
(3, 4, 1),
(4, 1, 5),
(4, 4, 1),
(6, 1, 2);

--
-- Déclencheurs `lignedecommande`
--
DROP TRIGGER IF EXISTS `AugmenterCA`;
DELIMITER //
CREATE TRIGGER `AugmenterCA` BEFORE INSERT ON `lignedecommande`
 FOR EACH ROW BEGIN
DECLARE idProduitI INTEger;
DECLARE idCatP integer;
DECLARE CAB integer;
Declare CAF integer;
DECLARE PrixI integer;
DECLARE PrixT integer;
DECLARE qteC integer;
DECLARE idClientI integer;
DECLARE isInter bool;
DECLARE idCom integer;
DECLARE idCliParCom integer;
DECLARE CAI integer;
DECLARE CAIF integer;
set idCom = new.idCommande;
set idCliParCom = (SELECT idCli from commande where idCommande = idCom);
set idClientI = (SELECT idClient from client WHERE idClient = idCliParCom);
set isInter = (SELECT isInternaute from client where idClient = idClientI);
                 
                 
                 
set idProduitI = new.idProduit;
set idCatP = (SELECT idCat from produit where idProduit = idProduitI);
set CAI = (SELECT CAInternaute from internaute WHERE idCli = idClientI);
set CAB = (SELECT CA from categorie where idCategorie = idCatP);
set qteC = new.QuantiteCom;
set PrixI = (SELECT PrixHTProduit from produit WHERE idProduit = idProduitI);
set PrixT = PrixI * qteC;
set CAIF = CAI + PrixT;
set CAF = CAB + PrixT;
UPDATE categorie set CA = CAF where idCategorie = idCatP;
if (isInter = 1)then
UPDATE internaute set CAInternaute = CAIF where idCli = idClientI;
end if;
    END
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `produit`
--

CREATE TABLE IF NOT EXISTS `produit` (
  `idProduit` int(11) NOT NULL,
  `LibelleProduit` varchar(100) DEFAULT NULL,
  `PrixHTProduit` float(6,2) DEFAULT NULL,
  `QteStockProduit` int(11) DEFAULT NULL,
  `idFourn` int(11) DEFAULT NULL,
  `idCat` int(11) DEFAULT NULL,
  PRIMARY KEY (`idProduit`),
  KEY `FKFourn` (`idFourn`),
  KEY `FKCat` (`idCat`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `produit`
--

INSERT INTO `produit` (`idProduit`, `LibelleProduit`, `PrixHTProduit`, `QteStockProduit`, `idFourn`, `idCat`) VALUES
(1, 'Optiplex 3010', 350.00, 10, 1, 1),
(2, 'Nas Server', 890.00, 6, 2, 1),
(3, 'Logiciel GestCom', 550.00, 10, 3, 2),
(4, 'Formation GestCom', 100.00, 10, 3, 3),
(5, 'Support Utilisateur', 150.00, 10, 3, 4);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
