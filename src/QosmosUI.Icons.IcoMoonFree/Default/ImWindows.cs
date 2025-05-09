// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.IcoMoonFree.Default;

public class ImWindows : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "16";

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
    public string ViewBox { get; set; } = "0 0 16 16";

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
		builder.AddAttribute(14, "d", "M6.441 7.999c-0.745-0.383-1.47-0.577-2.154-0.577-0.093 0-0.187 0.003-0.28 0.011-0.873 0.072-1.671 0.303-2.184 0.482-0.136 0.050-0.276 0.103-0.419 0.161l-1.403 4.866c0.964-0.357 1.817-0.53 2.598-0.53 1.263 0 2.18 0.472 2.937 0.958 0.359-1.217 1.219-4.158 1.476-5.036-0.187-0.114-0.376-0.228-0.571-0.333zM8.255 9.235l-1.413 4.909c0.419 0.24 1.83 1.001 2.91 1.001 0.872 0 1.848-0.223 2.982-0.684l1.349-4.718c-0.916 0.296-1.795 0.446-2.617 0.446-1.499 0-2.549-0.486-3.211-0.952zM4.575 5.762c1.205 0.012 2.096 0.472 2.835 0.945l1.449-4.958c-0.305-0.175-1.106-0.611-1.685-0.759-0.381-0.089-0.782-0.135-1.206-0.135-0.809 0.015-1.694 0.218-2.701 0.622l-1.382 4.853c1.013-0.382 1.885-0.568 2.689-0.568 0.001 0 0.002 0 0.002 0zM16 3.096c-0.919 0.357-1.816 0.539-2.672 0.539-1.433 0-2.489-0.497-3.173-0.974l-1.437 4.972c0.965 0.62 2.005 0.936 3.096 0.936 0.89 0 1.812-0.214 2.742-0.636l-0.003-0.035 0.058-0.014 1.39-4.788z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
