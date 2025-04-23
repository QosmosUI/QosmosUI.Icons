// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiWearos : ComponentBase
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
		builder.AddAttribute(15, "d", "M8.416 21.1346c-.9687 0-1.8938-.56-2.3135-1.5015L.2193 6.4198C-.3488 5.1432.2248 3.6472 1.5014 3.079c1.2767-.5681 2.7727.0055 3.3408 1.2821l5.8832 13.2133c.5681 1.2767-.0055 2.7727-1.2821 3.3408a2.5254 2.5254 0 01-1.0273.2194zm7.1952.0368c-.891 0-1.7412-.515-2.1268-1.3816L7.39 6.1024C6.867 4.9279 7.3955 3.5532 8.5686 3.03c1.173-.5218 2.5492.0054 3.0724 1.1785l6.0943 13.6888c.5232 1.1745-.0054 2.5492-1.1785 3.0724a2.3111 2.3111 0 01-.9456.2017zM24 5.195a2.3271 2.3271 0 01-2.3271 2.327 2.3271 2.3271 0 01-2.3271-2.327 2.3271 2.3271 0 012.327-2.3271A2.3271 2.3271 0 0124 5.1949zm-2.6119 5.116a2.4892 2.4892 0 01-2.4892 2.4893 2.4892 2.4892 0 01-2.4893-2.4892 2.4892 2.4892 0 012.4893-2.4893 2.4892 2.4892 0 012.4892 2.4893Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
