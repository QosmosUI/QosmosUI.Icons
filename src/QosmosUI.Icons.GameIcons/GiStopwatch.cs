// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiStopwatch : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M256 91.088c-111.453 0-202.122 88.575-202.122 197.456C53.878 397.426 144.548 486 256 486c111.453 0 202.122-88.574 202.122-197.456 0-108.881-90.67-197.455-202.122-197.455zm0 375.866c-100.942 0-183.076-80.039-183.076-178.41 0-98.37 82.134-178.41 183.076-178.41s183.076 80.04 183.076 178.41c0 98.371-82.134 178.41-183.076 178.41zm-.571-178.41l128.558 99.55A165.602 165.602 0 0 1 256 447.908c-90.467 0-164.03-71.493-164.03-159.365 0-87.681 73.266-159.055 163.447-159.352v159.352zM256 72.043a224.727 224.727 0 0 0-66.66 10.07V56.354A30.354 30.354 0 0 1 219.694 26h72.695a30.354 30.354 0 0 1 30.27 30.354v25.76A224.727 224.727 0 0 0 256 72.042zm128.939 40.71l20.117-19.748c8.797-8.642 21.272-10.463 27.878-4.083l20.403 19.748c6.594 6.38 4.761 18.558-3.988 27.2l-19.438 19.045a221.06 221.06 0 0 0-44.96-42.162zM82.435 154.51l-19.391-19.046c-8.797-8.642-10.713-20.724-4.202-26.985L78.875 89.1c6.476-6.26 18.856-4.344 27.652 4.298l20.046 19.688a221.06 221.06 0 0 0-44.138 41.425z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
