// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiPusher : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 24 24";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M12 23.966v-6.0166a.0348.0348 0 01.0182-.031l7.7319-4.4645a.0348.0348 0 00.0181-.031v-1.711a.0356.0356 0 00-.0537-.031l-7.6608 4.423a.0356.0356 0 01-.0537-.031v-1.7117a.0356.0356 0 01.0181-.031l7.732-4.4645a.037.037 0 00.0181-.031v-1.711a.0363.0363 0 00-.0537-.031l-7.6608 4.4229a.0356.0356 0 01-.0537-.031v-1.711a.0348.0348 0 01.0181-.031l7.732-4.4622a.0356.0356 0 00.0181-.031V4.515a.0757.0757 0 00-.0356-.062L12.0356.0096a.0704.0704 0 00-.0712 0L10.5002.855a.0356.0356 0 000 .062L18.161 5.34a.0363.0363 0 010 .062l-1.4642.8452a.0757.0757 0 01-.0719 0L8.9286 1.8038a.0757.0757 0 00-.0757 0l-1.4597.8445a.0356.0356 0 000 .062l7.6593 4.4236a.0356.0356 0 010 .0621l-1.4634.8452a.0757.0757 0 01-.0757 0l-7.6926-4.444a.0757.0757 0 00-.0756 0l-1.5134.8762v15.0492a.0348.0348 0 00.0181.031l1.4816.8558a.0356.0356 0 00.0538-.031V5.433a.0356.0356 0 01.0537-.031l1.4824.8558a.0356.0356 0 01.0174.031v15.028a.0356.0356 0 00.0181.031l1.4816.8559a.0363.0363 0 00.0545-.0318V7.227a.0356.0356 0 01.0537-.031l1.4817.855a.0356.0356 0 01.0181.0311v15.0288a.037.037 0 00.0174.031l1.4862.855A.0356.0356 0 0012 23.966z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
