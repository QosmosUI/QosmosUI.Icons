// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiFeedly : ComponentBase
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
		builder.AddAttribute(15, "d", "M13.85995 1.98852a2.60906 2.60906 0 00-3.72608 0L.76766 11.52674a2.72906 2.72906 0 000 3.79508l6.68415 6.80816a2.61806 2.61806 0 001.74004.66401h5.61313a2.61606 2.61606 0 001.87204-.79101l6.55415-6.67516a2.72606 2.72606 0 000-3.79508l-9.37021-9.54422zm-.26 17.4224l-.93502.95002a.372.372 0 01-.268.114h-.80003a.376.376 0 01-.247-.096l-.95402-.97002a.39.39 0 010-.54201l1.33703-1.36003a.37.37 0 01.531 0l1.33704 1.36103a.389.389 0 010 .543zm0-5.71113l-3.73709 3.80808a.374.374 0 01-.268.111h-.79902a.376.376 0 01-.25-.093l-.95103-.97002a.391.391 0 010-.54401l4.1391-4.2141a.372.372 0 01.531 0l1.33704 1.36204a.386.386 0 010 .54zm0-5.70713L7.0598 14.6528a.372.372 0 01-.268.113h-.80002a.373.373 0 01-.24901-.094l-.95302-.97202a.388.388 0 010-.54001L11.7329 6.0896a.372.372 0 01.531 0l1.33704 1.36004a.389.389 0 010 .543z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
