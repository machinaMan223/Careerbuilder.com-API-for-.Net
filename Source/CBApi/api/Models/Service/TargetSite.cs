﻿namespace com.careerbuilder.api.models.service
{
    public abstract class TargetSite
    {
        protected string _Domain;
        protected string _HostOverride = null;

        public string Domain
        {
            get { return _Domain; }
        }

        public string Host {
            get { return _HostOverride; }
        }
    }
}