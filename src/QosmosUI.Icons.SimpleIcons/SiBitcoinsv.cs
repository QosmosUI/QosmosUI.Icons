// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiBitcoinsv : ComponentBase
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
		builder.AddAttribute(15, "d", "M14.648 14.423l.003-.004a1.34 1.34 0 0 1-.498.659c-.269.189-.647.338-1.188.364l-1.99.004v-2.93c.288.008 1.565-.013 2.119.015.722.035 1.171.321 1.41.668.262.351.293.82.144 1.224zm-2.129-3.261c.503-.024.852-.162 1.101-.336.214-.146.375-.367.46-.611.134-.375.107-.81-.136-1.135-.223-.319-.638-.584-1.306-.616-.495-.026-1.413-.003-1.664-.01v2.709c.025.004 1.539-.001 1.545-.001zM24 12c0 6.627-5.373 12-12 12S0 18.627 0 12 5.373 0 12 0s12 5.373 12 12zm-6.65 2.142c.022-1.477-1.24-2.332-1.908-2.572.715-.491 1.206-1.043 1.206-2.085 0-1.655-1.646-2.43-2.647-2.529-.082-.009-.31-.013-.31-.013V5.361h-1.633l.004 1.583H10.97V5.367H9.31v1.569c-.292.007-2.049.006-2.049.006v1.401h.571c.601.016.822.362.798.677v6.041a.408.408 0 0 1-.371.391c-.249.011-.621 0-.621 0l-.32 1.588h1.996v1.6h1.661v-1.591h1.091v1.594h1.624v-1.588c1.899.05 3.643-1.071 3.66-2.913z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
