#!/usr/bin/env janet

(use cbt-1.0.0)

(use /src/object-blueprints)
(use /src/poptables)


(declare-mod
  "archipelago"
  "Archipelago Randomizer for Caves of Qud"
  "petrak@"
  "0.1.0"
  :description "Archipelago but for CoQ"
  :thumbnail "thumbnail.png")

(generate-xml "ObjectBlueprints.xml" object-blueprints)
(generate-xml "Populations.xml" poptables)
