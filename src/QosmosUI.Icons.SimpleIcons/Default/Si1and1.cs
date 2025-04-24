// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class Si1and1 : ComponentBase
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
		builder.AddAttribute(15, "d", "M0 0v24h24V0zm11.717 5.792c1.564 0 2.671 1.04 2.671 2.468 0 1.044-.428 1.819-1.746 2.915l1.952 2.648c.163-.147.303-1.046.274-1.777-.003-.087-.022-.341-.04-.62h1.814c0 .244.024.595.024.683 0 1.426-.224 2.327-.909 3.198L17.2 17.22h-2.232l-.503-.678c-.823.659-1.546.905-2.713.898-2.284-.013-3.857-1.173-4.005-3.239-.089-1.235.737-2.506 2.32-3.42C9.049 9.477 8.84 9.025 8.84 8.207c0-1.392 1.191-2.415 2.878-2.415zm-9.424.134h4.064v11.296H4.1V7.735H2.293zm14.45 0h4.065v11.296H18.55V7.735h-1.807zm-5.036 1.49c-.545 0-.931.358-.931.845 0 .47.14.726.79 1.562.772-.557 1.058-1.075 1.058-1.58 0-.504-.354-.828-.917-.828zm-.517 4.811c-1.002.663-1.404 1.31-1.386 1.919.03.928.806 1.522 1.948 1.522.703 0 1.174-.257 1.579-.594z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
