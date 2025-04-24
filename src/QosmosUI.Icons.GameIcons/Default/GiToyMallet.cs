// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiToyMallet : ComponentBase
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
		builder.AddAttribute(14, "d", "M233.561 26.007l-24.539 11.154-67.328 67.329-11.154 24.539 24.537-11.153 67.332-67.332zm26.115 26.111l-24.539 11.155-67.33 67.33-11.154 24.539 24.541-11.154 67.328-67.328zm26.114 26.116L261.247 89.39l-67.324 67.324-11.157 24.543 24.54-11.154 67.327-67.326zm26.113 26.113l-24.543 11.156-67.324 67.324-11.156 24.543 24.54-11.154 67.329-67.328zm-3.637 42.479l-56.908 56.908 56.908 56.908 56.908-56.908zm99.387 53.271l-24.543 11.156-67.326 67.326-11.154 24.541 24.543-11.156 67.324-67.324zm26.113 26.113l-24.543 11.157-67.326 67.328-11.154 24.539 24.543-11.157 67.324-67.324zm-183.531 1.858l-50.62 50.619c8.136 1.446 15.919 5.283 22.167 11.531v.002c6.248 6.248 10.085 14.03 11.531 22.164l50.62-50.619zm209.647 24.256l-24.542 11.154-67.328 67.328-11.154 24.541 24.54-11.154 67.33-67.33zm26.11 26.115l-24.536 11.152-67.332 67.332-11.153 24.537 24.54-11.154 67.328-67.328zM192.207 295.91c-6.08 0-12.158 2.343-16.848 7.034-9.38 9.38-9.38 24.317 0 33.697 9.38 9.38 24.315 9.38 33.695 0 9.38-9.38 9.38-24.315 0-33.695-4.69-4.69-10.768-7.035-16.847-7.036zm-46.424 46.424c-6.08 0-12.158 2.345-16.848 7.035-9.38 9.38-9.38 24.315 0 33.696 9.38 9.38 24.315 9.38 33.696 0 9.38-9.38 9.382-24.315.002-33.696-4.69-4.69-10.77-7.035-16.85-7.035zm-41.108 31.293l-68.59 68.59c-14.58 14.58-11.324 28.174-2.9 36.598s22.017 11.68 36.598-2.9l68.59-68.59c-8.135-1.446-15.918-5.283-22.166-11.532-6.249-6.248-10.086-14.03-11.532-22.166z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
