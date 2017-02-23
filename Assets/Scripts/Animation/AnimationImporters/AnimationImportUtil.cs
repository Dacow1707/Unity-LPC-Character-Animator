﻿using Assets.Scripts.Animation.AnimationDirections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Animation.AnimationImporters {
    public class AnimationImportUtil {
        public AnimationDNABlock BuildAnimation(SingleAnimationImporter animationDefinition, string spritesheetKey, BaseAnimationDirection direction) {
            // TODO: Stop passing direction through here..
            List<Sprite> spriteList = new List<Sprite>();

            string animationKey = spritesheetKey + "_" + animationDefinition.TagName;

            for (int i = 0; i < animationDefinition.NumberOfFrames; i++) {
                string spriteKey = animationKey + "_" + i;
                Sprite sprite = AtlasManager.GetSprite(spriteKey);
                spriteList.Add(sprite);
            }

            return new AnimationDNABlock(animationKey, spriteList, direction);
        }
    }
}
