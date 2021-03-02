-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           8.0.20 - MySQL Community Server - GPL
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              11.1.0.6116
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Copiando estrutura do banco de dados para ecce
CREATE DATABASE IF NOT EXISTS `ecce` /*!40100 DEFAULT CHARACTER SET utf8 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `ecce`;

-- Copiando estrutura para tabela ecce.tb_categoria
CREATE TABLE IF NOT EXISTS `tb_categoria` (
  `CodigoCategoria` int NOT NULL AUTO_INCREMENT,
  `Descricao` varchar(50) NOT NULL,
  PRIMARY KEY (`CodigoCategoria`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela ecce.tb_cor
CREATE TABLE IF NOT EXISTS `tb_cor` (
  `CodigoCor` int NOT NULL AUTO_INCREMENT,
  `Descricao` varchar(50) NOT NULL DEFAULT '0',
  PRIMARY KEY (`CodigoCor`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela ecce.tb_endereco
CREATE TABLE IF NOT EXISTS `tb_endereco` (
  `CodigoEndereco` int NOT NULL AUTO_INCREMENT,
  `CodigoLogin` int DEFAULT NULL,
  `Descricao` varchar(50) DEFAULT NULL,
  `CEP` varchar(10) DEFAULT NULL,
  `Endereco` varchar(100) DEFAULT NULL,
  `Numero` int DEFAULT NULL,
  `Bairro` varchar(100) DEFAULT NULL,
  `Cidade` varchar(100) DEFAULT NULL,
  `UF` varchar(2) DEFAULT NULL,
  PRIMARY KEY (`CodigoEndereco`),
  KEY `CodigoLogin` (`CodigoLogin`),
  CONSTRAINT `FK__tb_login` FOREIGN KEY (`CodigoLogin`) REFERENCES `tb_login` (`CodigoLogin`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela ecce.tb_funcionario_funcao
CREATE TABLE IF NOT EXISTS `tb_funcionario_funcao` (
  `CodigoFuncao` int NOT NULL AUTO_INCREMENT,
  `Descricao` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`CodigoFuncao`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela ecce.tb_genero
CREATE TABLE IF NOT EXISTS `tb_genero` (
  `CodigoGenero` int NOT NULL AUTO_INCREMENT,
  `Descricao` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  PRIMARY KEY (`CodigoGenero`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela ecce.tb_login
CREATE TABLE IF NOT EXISTS `tb_login` (
  `CodigoLogin` int NOT NULL AUTO_INCREMENT,
  `Nome` varchar(50) DEFAULT NULL,
  `Email` varchar(100) NOT NULL DEFAULT '0',
  `Telefone` varchar(15) NOT NULL DEFAULT '0',
  `CPF_CNPJ` varchar(15) NOT NULL DEFAULT '0',
  `Senha` text,
  `Tipo` varchar(50) DEFAULT NULL,
  `DataCadastro` datetime DEFAULT NULL,
  `Ativo` bit(1) DEFAULT NULL,
  `CodigoFuncao` int DEFAULT NULL,
  PRIMARY KEY (`CodigoLogin`) USING BTREE,
  KEY `CodigoFuncao` (`CodigoFuncao`),
  CONSTRAINT `FK_tb_login_tb_funcionario_funcao` FOREIGN KEY (`CodigoFuncao`) REFERENCES `tb_funcionario_funcao` (`CodigoFuncao`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela ecce.tb_nf
CREATE TABLE IF NOT EXISTS `tb_nf` (
  `CodigoTbNf` int NOT NULL AUTO_INCREMENT,
  `CodigoNF` varchar(50) NOT NULL DEFAULT '',
  `CodigoVenda` int DEFAULT NULL,
  `ValorNF` double DEFAULT NULL,
  `DataRegistro` datetime DEFAULT NULL,
  PRIMARY KEY (`CodigoTbNf`),
  KEY `CodigoVenda` (`CodigoVenda`),
  CONSTRAINT `FK_tb_nf_tb_venda` FOREIGN KEY (`CodigoVenda`) REFERENCES `tb_venda` (`CodigoVenda`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela ecce.tb_produto
CREATE TABLE IF NOT EXISTS `tb_produto` (
  `CodigoProduto` int NOT NULL AUTO_INCREMENT,
  `Nome` varchar(50) NOT NULL DEFAULT '0',
  `Descricao` varchar(255) NOT NULL DEFAULT '0',
  `Valor` double NOT NULL DEFAULT '0',
  `DataRegistro` datetime DEFAULT NULL,
  `Peso` double NOT NULL DEFAULT '0',
  PRIMARY KEY (`CodigoProduto`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela ecce.tb_produto_categoria
CREATE TABLE IF NOT EXISTS `tb_produto_categoria` (
  `CodigoCategoria` int NOT NULL,
  `CodigoProduto` int NOT NULL,
  PRIMARY KEY (`CodigoCategoria`),
  KEY `CodigoProduto` (`CodigoProduto`),
  CONSTRAINT `FK_tb_produto_categoria_tb_categoria` FOREIGN KEY (`CodigoCategoria`) REFERENCES `tb_categoria` (`CodigoCategoria`),
  CONSTRAINT `FK_tb_produto_categoria_tb_produto` FOREIGN KEY (`CodigoProduto`) REFERENCES `tb_produto` (`CodigoProduto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela ecce.tb_produto_cor
CREATE TABLE IF NOT EXISTS `tb_produto_cor` (
  `CodigoCor` int NOT NULL,
  `CodigoProduto` int NOT NULL,
  PRIMARY KEY (`CodigoCor`),
  KEY `CodigoProduto` (`CodigoProduto`),
  CONSTRAINT `FK_tb_produto_cor_tb_cor` FOREIGN KEY (`CodigoCor`) REFERENCES `tb_cor` (`CodigoCor`),
  CONSTRAINT `FK_tb_produto_cor_tb_produto` FOREIGN KEY (`CodigoProduto`) REFERENCES `tb_produto` (`CodigoProduto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela ecce.tb_produto_estoque
CREATE TABLE IF NOT EXISTS `tb_produto_estoque` (
  `CodigoEstoque` int NOT NULL AUTO_INCREMENT,
  `NFEntrada` varchar(50) DEFAULT NULL,
  `DataNFEntrada` date DEFAULT NULL,
  `DataVencimentoGarantia` date DEFAULT NULL,
  `DataRegistro` datetime DEFAULT NULL,
  PRIMARY KEY (`CodigoEstoque`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela ecce.tb_produto_estoque_movimentacao
CREATE TABLE IF NOT EXISTS `tb_produto_estoque_movimentacao` (
  `CodigoMovimentacao` int NOT NULL AUTO_INCREMENT,
  `CodigoEstoque` int DEFAULT NULL,
  `CodigoProduto` int DEFAULT NULL,
  `CodigoOperacao` int DEFAULT NULL,
  `TipoMovimentacao` varchar(10) DEFAULT NULL,
  `DataRegistro` datetime DEFAULT NULL,
  PRIMARY KEY (`CodigoMovimentacao`),
  KEY `CodigoEstoque` (`CodigoEstoque`),
  KEY `CodigoProduto` (`CodigoProduto`),
  KEY `CodigoOperacao` (`CodigoOperacao`),
  CONSTRAINT `FK__tb_produto` FOREIGN KEY (`CodigoProduto`) REFERENCES `tb_produto` (`CodigoProduto`),
  CONSTRAINT `FK__tb_produto_estoque` FOREIGN KEY (`CodigoEstoque`) REFERENCES `tb_produto_estoque` (`CodigoEstoque`),
  CONSTRAINT `FK__tb_produto_estoque_operacao` FOREIGN KEY (`CodigoOperacao`) REFERENCES `tb_produto_estoque_operacao` (`CodigoOperacao`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela ecce.tb_produto_estoque_operacao
CREATE TABLE IF NOT EXISTS `tb_produto_estoque_operacao` (
  `CodigoOperacao` int NOT NULL AUTO_INCREMENT,
  `Descricao` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`CodigoOperacao`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela ecce.tb_produto_foto
CREATE TABLE IF NOT EXISTS `tb_produto_foto` (
  `CodigoFoto` int NOT NULL AUTO_INCREMENT,
  `CodigoProduto` int NOT NULL,
  `Descricao` varchar(50) NOT NULL,
  `Caminho` varchar(50) NOT NULL,
  PRIMARY KEY (`CodigoFoto`),
  KEY `CodigoFoto` (`CodigoProduto`) USING BTREE,
  CONSTRAINT `FK_tb_produto_foto` FOREIGN KEY (`CodigoProduto`) REFERENCES `tb_produto` (`CodigoProduto`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela ecce.tb_produto_genero
CREATE TABLE IF NOT EXISTS `tb_produto_genero` (
  `CodigoGenero` int NOT NULL,
  `CodigoProduto` int NOT NULL,
  PRIMARY KEY (`CodigoGenero`),
  KEY `CodigoProduto` (`CodigoProduto`),
  CONSTRAINT `FK_tb_produto_genero_tb_genero` FOREIGN KEY (`CodigoGenero`) REFERENCES `tb_genero` (`CodigoGenero`),
  CONSTRAINT `FK_tb_produto_genero_tb_produto` FOREIGN KEY (`CodigoProduto`) REFERENCES `tb_produto` (`CodigoProduto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela ecce.tb_produto_tamanho
CREATE TABLE IF NOT EXISTS `tb_produto_tamanho` (
  `CodigoTamanho` int NOT NULL,
  `CodigoProduto` int NOT NULL,
  PRIMARY KEY (`CodigoTamanho`),
  KEY `CodigoProduto` (`CodigoProduto`),
  CONSTRAINT `FK_tb_produto_tamanho_tb_produto` FOREIGN KEY (`CodigoProduto`) REFERENCES `tb_produto` (`CodigoProduto`),
  CONSTRAINT `FK_tb_produto_tamanho_tb_tamanho` FOREIGN KEY (`CodigoTamanho`) REFERENCES `tb_tamanho` (`CodigoTamanho`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela ecce.tb_tamanho
CREATE TABLE IF NOT EXISTS `tb_tamanho` (
  `CodigoTamanho` int NOT NULL AUTO_INCREMENT,
  `Descricao` varchar(50) NOT NULL DEFAULT '0',
  PRIMARY KEY (`CodigoTamanho`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela ecce.tb_venda
CREATE TABLE IF NOT EXISTS `tb_venda` (
  `CodigoVenda` int NOT NULL AUTO_INCREMENT,
  `CodigoLogin` int DEFAULT NULL,
  `CodigoEndereco` int DEFAULT NULL,
  `ParcelaTotal` int DEFAULT NULL,
  `ValorTotal` double DEFAULT NULL,
  `ValorDesconto` double DEFAULT NULL,
  `ValorFinal` double DEFAULT NULL,
  `DataRegistro` datetime DEFAULT NULL,
  `Status` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`CodigoVenda`),
  KEY `CodigoLogin` (`CodigoLogin`),
  KEY `CodigoEndereco` (`CodigoEndereco`),
  CONSTRAINT `FK__tb_endereco` FOREIGN KEY (`CodigoEndereco`) REFERENCES `tb_endereco` (`CodigoEndereco`),
  CONSTRAINT `FK__tb_login_endereco` FOREIGN KEY (`CodigoLogin`) REFERENCES `tb_login` (`CodigoLogin`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela ecce.tb_venda_forma_pagamento
CREATE TABLE IF NOT EXISTS `tb_venda_forma_pagamento` (
  `CodigoFormaPagamento` int NOT NULL AUTO_INCREMENT,
  `Descricao` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`CodigoFormaPagamento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela ecce.tb_venda_itens
CREATE TABLE IF NOT EXISTS `tb_venda_itens` (
  `CodigoVendaItens` int NOT NULL AUTO_INCREMENT,
  `CodigoVenda` int DEFAULT NULL,
  `CodigoProduto` int DEFAULT NULL,
  `Valor` double DEFAULT NULL,
  `Quantidade` int DEFAULT NULL,
  PRIMARY KEY (`CodigoVendaItens`),
  KEY `CodigoProduto` (`CodigoProduto`),
  KEY `CodigoVenda` (`CodigoVenda`),
  CONSTRAINT `FK_tb_venda_itens_tb_produto` FOREIGN KEY (`CodigoProduto`) REFERENCES `tb_produto` (`CodigoProduto`),
  CONSTRAINT `FK_tb_venda_itens_tb_venda` FOREIGN KEY (`CodigoVenda`) REFERENCES `tb_venda` (`CodigoVenda`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela ecce.tb_venda_recebimento
CREATE TABLE IF NOT EXISTS `tb_venda_recebimento` (
  `CodigoVendaRecebimento` int NOT NULL AUTO_INCREMENT,
  `CodigoVenda` int DEFAULT NULL,
  `CodigoFormaPagamento` int DEFAULT NULL,
  `Parcela` int(10) unsigned zerofill DEFAULT NULL,
  `Valor` double DEFAULT NULL,
  `CodigoTransacao` varchar(100) DEFAULT NULL,
  `DataRecebimento` datetime DEFAULT NULL,
  `DataRegistro` datetime DEFAULT NULL,
  PRIMARY KEY (`CodigoVendaRecebimento`),
  KEY `CodigoVenda` (`CodigoVenda`),
  KEY `CodigoFormaPagamento` (`CodigoFormaPagamento`),
  CONSTRAINT `FK__tb_venda` FOREIGN KEY (`CodigoVenda`) REFERENCES `tb_venda` (`CodigoVenda`),
  CONSTRAINT `FK__tb_venda_forma_pagamento` FOREIGN KEY (`CodigoFormaPagamento`) REFERENCES `tb_venda_forma_pagamento` (`CodigoFormaPagamento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
