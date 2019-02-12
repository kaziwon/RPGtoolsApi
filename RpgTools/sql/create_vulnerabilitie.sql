CREATE TABLE `vulnerabilitie` (
	`id_vulnerabilitie` INT(10) UNSIGNED NOT NULL,
	`name_vulnerabilitie` VARCHAR(50) NULL DEFAULT NULL,
	`Description` VARCHAR(5000) NULL DEFAULT NULL,
	`ID_MONSTER` INT(10) UNSIGNED NULL DEFAULT NULL,
	PRIMARY KEY (`id_vulnerabilitie`),
	INDEX `FK_TALENTMONSTER` (`ID_MONSTER`),
	CONSTRAINT `FK_VULNMONSTER` FOREIGN KEY (`ID_MONSTER`) REFERENCES `monsters` (`id_monster`)
)
COLLATE='utf8mb4_0900_ai_ci'
ENGINE=InnoDB
;