﻿namespace Jambo.Domain.Model.Blogs.Events
{
    public class BlogDisabledDomainEvent : DomainEvent
    {
        public BlogDisabledDomainEvent()
        {

        }

        public BlogDisabledDomainEvent(AggregateRoot aggregateRoot)
            : base(aggregateRoot)
        {
        }
    }
}
