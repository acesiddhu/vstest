// Copyright (c) Microsoft. All rights reserved.

namespace Microsoft.VisualStudio.TestPlatform.CrossPlatEngine.DataCollection.Interfaces
{
    using System;
    using System.Collections.ObjectModel;

    using Microsoft.VisualStudio.TestPlatform.CrossPlatEngine.DataCollection.Interfaces;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;

    /// <summary>
    /// The ProxyDataCollectionManager interface.
    /// </summary>
    public interface IProxyDataCollectionManager : IDisposable
    {
        /// <summary>
        /// Invoked before starting of test run
        /// </summary>
        /// <param name="resetDataCollectors">
        /// Bool value to reset and reinitialize datacollectors.
        /// </param>
        /// <param name="isRunStartingNow">
        /// Bool value to specify if the test execution has started or not.
        /// </param>
        /// <param name="runEventsHandler">
        /// The run Events Handler.
        /// </param>
        /// <returns>
        /// BeforeTestRunStartResult object
        /// </returns>
        DataCollectionParameters BeforeTestRunStart(
            bool resetDataCollectors,
            bool isRunStartingNow,
            ITestMessageEventHandler runEventsHandler);

        /// <summary>
        /// Invoked after ending of test run
        /// </summary>
        /// <param name="isCanceled">
        /// The is Canceled.
        /// </param>
        /// <param name="runEventsHandler">
        /// The run Events Handler.
        /// </param>
        /// <returns>
        /// The <see cref="Collection"/>.
        /// </returns>
        Collection<AttachmentSet> AfterTestRunEnd(bool isCanceled, ITestMessageEventHandler runEventsHandler);
    }
}