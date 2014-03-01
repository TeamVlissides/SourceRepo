using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// gemType
/*
 * 
 * The type will be what the Characters class will use
 * to determine what to do with a gem.
 * 
 */

namespace CSGameSystem
{
    class Gem
    {
        // Attributes
        private String gemName;
        private String gemImagePath;
        private int gemType;

        // Constructors
        public Gem()
        {
            this.gemName = "Generic Gem";
            this.gemImagePath = "";
            this.gemType = 0;
        }

        public Gem(String name, String path, int type)
        {
            this.gemName = name;
            this.gemImagePath = path;
            this.gemType = type;
        }

        // getters Methods
        public String getGemName()
        {
            return this.gemName;
        }

        public String getGemImagePath()
        {
            return this.gemImagePath;
        }

        public int getGemType()
        {
            return this.gemType;
        }

        // setter Methods
        public void setGemName(String name)
        {
            this.gemName = name;
        }

        public void setGemImagePath(String path)
        {
            this.gemImagePath = path;
        }

        public void setGemType(int type)
        {
            this.gemType = type;
        }

    }
}
