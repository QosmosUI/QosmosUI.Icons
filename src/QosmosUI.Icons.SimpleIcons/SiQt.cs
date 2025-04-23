// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiQt : ComponentBase
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
		builder.AddAttribute(15, "d", "M21.693 3.162H3.33L0 6.49v14.348h20.671L24 17.51V3.162zM12.785 18.4l-1.562.728-1.35-2.217c-.196.057-.499.09-.924.09-1.579 0-2.683-.425-3.305-1.276-.622-.85-.932-2.2-.932-4.033 0-1.84.319-3.206.949-4.098.63-.892 1.726-1.341 3.288-1.341 1.562 0 2.658.441 3.28 1.333.63.883.94 2.25.94 4.098 0 1.219-.13 2.2-.384 2.945-.261.752-.679 1.325-1.268 1.718zm4.736-1.587c-.858 0-1.447-.196-1.766-.59-.32-.392-.483-1.136-.483-2.232v-3.534H14.11V9.051h1.162V6.843h1.644V9.05h2.094v1.415h-2.094v3.346c0 .622.05 1.03.14 1.227.09.204.326.303.695.303l1.243-.05.073 1.326c-.67.13-1.186.196-1.546.196zm-8.58-9.08c-.95 0-1.604.311-1.963.94-.352.63-.532 1.629-.532 3.011 0 1.374.172 2.364.515 2.953.344.589 1.006.892 1.98.892.973 0 1.628-.295 1.971-.876.335-.58.507-1.57.507-2.953 0-1.39-.172-2.396-.523-3.026-.352-.63-1.006-.94-1.955-.94Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
